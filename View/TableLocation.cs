﻿using ParkEase.Constants;
using ParkEase.Controller;
using ParkEase.Model.Entity;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace ParkEase.View
{
    public partial class TableLocation : Form
    {
        protected LocationController _controller;
        protected Location[]? _content;
        protected int _page = 1;
        protected int _limit = App.DEFAULT_PAGINATION_LIMIT;
        protected string? _search;
        protected string? _order;
        protected string? _orderBy;
        protected bool _hasNext = false;
        private DataGridViewColumn? lastColumn;
        Subject<string> _searchSubject;

        public TableLocation()
        {
            InitializeComponent();
            _controller = new LocationController();
            _searchSubject = new Subject<string>();
            LoadData();
            InitDebounce();
        }
        public void InitDebounce()
        {
            _searchSubject
              .Throttle(TimeSpan.FromMilliseconds(400))
              .Subscribe(DebounceSearch);
            txtSearch.TextChanged += onChange;
        }

        protected void LoadData()
        {
            var param = new BaseRequestPagination<LocationFilterRequest>()
            {
                Limit = _limit,
                Order = _order,
                OrderBy = _orderBy,
                Page = _page,
                Search = _search,
            };

            try
            {
                var data = _controller.GetAllLocation(param);
                var content = data?.Data?.Content;
                if (content != null) _content = content;
                var metadata = data?.Data?.Metadata;
                _page = data?.Data?.Metadata?.Page ?? 1;
                _hasNext = data?.Data?.Metadata?.HasNext ?? false;

                TriggerButtonState();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected void ShowData()
        {
            lvwTable.Rows.Clear();
            for (int idx = 0; idx < _content?.Length; idx++)
            {
                var val = _content[idx];
                lvwTable.Rows.Add(
                    new object[]
                    {
                            _limit*(_page-1)+idx+1,
                            val.Code,
                            val.Name,
                            val.IsExit,
                    }
                );
            }
        }

        protected void TriggerButtonState()
        {
            btnPrev.Enabled = _page > 1;
            btnNext.Enabled = _hasNext;
        }

        private void onChange(object? sender, EventArgs e)
        {
            _searchSubject.OnNext(txtSearch.Text);
        }

        private void DebounceSearch(string searchText)
        {
            _search = searchText;
            lvwTable.Invoke((MethodInvoker)(() => LoadData()));
        }

        private void onSort(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = lvwTable.Columns[e.ColumnIndex];

            if (lastColumn != null && column != lastColumn)
            {
                lastColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            switch (column.HeaderCell.SortGlyphDirection)
            {
                case SortOrder.Ascending:
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
                    _order = null;
                    break;
                case SortOrder.Descending:
                    column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    _order = "asc";
                    break;
                default:
                    column.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    _order = "desc";
                    break;
            }

            switch (column.Name)
            {
                case "columnNo":
                    _orderBy = "date";
                    break;
                case "columnName":
                    _orderBy = "name";
                    break;
                case "columnCode":
                    _orderBy = "code";
                    break;
                case "columnIsExit":
                    _orderBy = "is_exit";
                    break;
                default:
                    _orderBy = null;
                    break;
            }

            lastColumn = column;
            lvwTable.Invoke((MethodInvoker)(() => LoadData()));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmInput = new FormLocation();
            frmInput.IsCreate(true);
            frmInput.OnLoadData += LoadData;
            frmInput.StartPosition = FormStartPosition.CenterScreen;
            frmInput.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwTable.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No item selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };

            if (_content?.Length <= 0) return;
            var selectedItem = _content![lvwTable.SelectedRows[0].Index];
            var frmInput = new FormLocation();
            frmInput.IsCreate(false);
            frmInput.OnLoadData += LoadData;
            frmInput.SetData(selectedItem);
            frmInput.StartPosition = FormStartPosition.CenterScreen;
            frmInput.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwTable.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No item selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };

            DialogResult dialog = MessageBox.Show("Are you sure to delete this item?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Cancel) return;

            if (_content?.Length <= 0) return;
            var selectedItem = _content![lvwTable.SelectedRows[0].Index];
            try
            {
                _controller.DeleteLocation(selectedItem.Code);
                LoadData();
                MessageBox.Show("Success delete Location", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _page += 1;
            LoadData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _page -= 1;
            LoadData();
        }
    }
}
