using ParkEase.Constants;
using ParkEase.Controller;
using ParkEase.Model.Entity;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace ParkEase.View
{
    public partial class TableHistory : Form
    {
        protected HistoryController _controller;
        protected LocationController _locationController;
        protected VehicleTypeController _vehicleTypeController;
        protected History[]? _content;
        protected Location[]? _locations;
        protected VehicleType[]? _vehicleTypes;
        protected int _page = 1;
        protected int _limit = App.DEFAULT_PAGINATION_LIMIT;
        protected string? _search;
        protected string? _order;
        protected string? _orderBy;
        protected string? _vehicleType;
        protected string? _location;
        protected bool _hasNext = false;
        private DataGridViewColumn? lastColumn;
        Subject<string> _searchSubject;

        public TableHistory()
        {
            InitializeComponent();
            _controller = new HistoryController();
            _locationController = new LocationController();
            _vehicleTypeController = new VehicleTypeController();
            _searchSubject = new Subject<string>();
            InitializeCombobox();
            LoadData();
            InitializeLocation();
            InitializeVehicleType();
            InitDebounce();
        }

        private void InitializeCombobox()
        {
            cmbLocation.Items.Add("Location");
            cmbVehicleType.Items.Add("Vehicle Type");
            cmbLocation.SelectedIndex = 0;
            cmbVehicleType.SelectedIndex = 0;
        }

        private void InitializeLocation()
        {
            var param = new BaseRequestPagination<LocationFilterRequest>()
            {
                Limit = App.DEFAULT_MAX_PAGINATION_LIMIT,
                Page = 1,
            };

            try
            {
                var data = _locationController.GetAllLocation(param);
                var content = data?.Data?.Content;
                if (content != null) _locations = content;
                if (_locations == null) return;
                foreach (var location in _locations)
                {
                    cmbLocation.Items.Add(location.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitializeVehicleType()
        {
            var param = new BaseRequestPagination()
            {
                Limit = App.DEFAULT_MAX_PAGINATION_LIMIT,
                Page = 1
            };

            try
            {
                var data = _vehicleTypeController.GetAllVehicleType(param);
                var content = data?.Data?.Content;
                if (content != null) _vehicleTypes = content;
                if (_vehicleTypes == null) return;
                foreach (var vehicleType in _vehicleTypes)
                {
                    cmbVehicleType.Items.Add(vehicleType.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            System.Diagnostics.Debug.Print("run load data");
            var param = new BaseRequestPagination<HistoryFilterRequest>()
            {
                Limit = _limit,
                Order = _order,
                OrderBy = _orderBy,
                Page = _page,
                Search = _search,
                Additional = new HistoryFilterRequest()
                {
                    Location = _location,
                    VehicleType = _vehicleType,
                }
            };

            try
            {
                var data = _controller.GetAllHistory(param);
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
                            val.Id,
                            val.LocationCode,
                            val.VehicleTypeCode,
                            val.VehicleNumber,
                            val.Date,
                            val.Type,
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
                case "columnId":
                    _orderBy = "id";
                    break;
                case "columnLocation":
                    _orderBy = "location_code";
                    break;
                case "columnVehicleType":
                    _orderBy = "vehicle_type_code";
                    break;
                case "columnVehicleNumber":
                    _orderBy = "vehicle_number";
                    break;
                case "columnDate":
                    _orderBy = "date";
                    break;
                case "columnType":
                    _orderBy = "type";
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
            var frmInput = new FormEntryHistory();
            frmInput.OnLoadData += LoadData;
            frmInput.StartPosition = FormStartPosition.CenterScreen;
            frmInput.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (lvwTable.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No item selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };

            if (_content?.Length <= 0) return;
            var selectedItem = _content![lvwTable.SelectedRows[0].Index];
            var frmInput = new FormExitHistory();
            frmInput.OnLoadData += LoadData;
            frmInput.SetData(selectedItem);
            frmInput.StartPosition = FormStartPosition.CenterScreen;
            frmInput.GetPrice();
            frmInput.Show();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            if (lvwTable.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No item selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };

            if (_content?.Length <= 0) return;
            var selectedItem = _content![lvwTable.SelectedRows[0].Index];
            var frmInput = new FormFineHistory();
            frmInput.OnLoadData += LoadData;
            frmInput.SetData(selectedItem);
            frmInput.StartPosition = FormStartPosition.CenterScreen;
            frmInput.GetPrice();
            frmInput.Show();
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            btnExit.Enabled = false;
            btnFine.Enabled = false;

            if (lvwTable.SelectedRows.Count <= 0) return;
            if (_content?.Length <= 0) return;
            var selectedItem = _content![lvwTable.SelectedRows[0].Index];
            if (selectedItem.Type == "entry")
            {
                btnExit.Enabled = true;
                btnFine.Enabled = true;
                return;
            }
        }

        private void onChangeVehicleType(object sender, EventArgs e)
        {
            if (_vehicleTypes == null) return;
            string? currentValue = _vehicleType;
            if (cmbVehicleType.SelectedIndex <= 0)
            {
                _vehicleType = null;
            }
            else
            {
                _vehicleType = _vehicleTypes[cmbVehicleType.SelectedIndex - 1].Code;
            }
            if (currentValue == _vehicleType) return;
            LoadData();
        }

        private void onChangeLocation(object sender, EventArgs e)
        {
            if (_locations == null) return;
            string? currentValue = _location;
            if (cmbLocation.SelectedIndex <= 0)
            {
                _location = null;
            }
            else
            {
                _location = _locations[cmbLocation.SelectedIndex - 1].Code;
            }
            if (currentValue == _location) return;
            LoadData();
        }
    }
}
