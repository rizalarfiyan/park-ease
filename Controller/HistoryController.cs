using ParkEase.Model.Entity;
using ParkEase.Model.Repository;
using ParkEase.Model.Response;

namespace ParkEase.Controller
{
    public class HistoryController
    {
        private HistoryRepository _repo;

        public HistoryController()
        {
            _repo = new HistoryRepository();
        }

        public BaseResponse<BaseResponsePagination<History>>? GetAllHistory(BaseRequestPagination param)
        {
            var res = _repo.GetAllHistory(param);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }

            return res;
        }

        public void CreateEntryHistory(string locationCode, string vehicleNumber, string vehicleTypeCode)
        {
            if (string.IsNullOrEmpty(locationCode))
            {
                throw new Exception("Location cannot be blank.");
            }

            if (string.IsNullOrEmpty(vehicleNumber))
            {
                throw new Exception("Vehicle Number cannot be blank.");
            }

            if (string.IsNullOrEmpty(vehicleTypeCode))
            {
                throw new Exception("Vehicle Type cannot be blank.");
            }

            var payload = new EntryHistoryRequest()
            {
                LocationCode = locationCode,
                VehicleNumber = vehicleNumber,
                VehicleTypeCode = vehicleTypeCode
            };

            BaseResponse<string?>? res = _repo.CreateEntryHistory(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }
    }
}
