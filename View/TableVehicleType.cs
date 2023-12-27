﻿using ParkEase.Constants;
using ParkEase.Controller;
using ParkEase.Model.Entity;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace ParkEase.View
{
    public partial class TableVehicleType : Form
    {
        protected VehicleTypeController _controller;
        protected VehicleType[]? _content;
        protected int _page = 1;
        protected string? _search;
        protected string? _order;
        protected string? _orderBy;
        protected bool _hasNext = false;
        Subject<string> _searchSubject;

        public TableVehicleType()
        {
            InitializeComponent();
            _controller = new VehicleTypeController();
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
            var param = new BaseRequestPagination()
            {
                Limit = App.DEFAULT_PAGINATION_LIMIT,
                Order = _order,
                OrderBy = _orderBy,
                Page = _page,
                Search = _search,
            };

            try
            {
                var data = _controller.GetAllVehicleType(param);
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
                            idx+1,
                            val.Code,
                            val.Name,
                            val.Price,
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
    }
}