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

        public void CreateExitHistory(string entryHistoryId, string locationCode, int price)
        {
            if (string.IsNullOrEmpty(entryHistoryId))
            {
                throw new Exception("Entry History Id cannot be blank.");
            }

            if (string.IsNullOrEmpty(locationCode))
            {
                throw new Exception("Location cannot be blank.");
            }

            if (price <= 0)
            {
                throw new Exception("Price cannot be blank.");
            }

            var payload = new ExitHistoryRequest()
            {
                EntryHistoryId = entryHistoryId,
                LocationCode = locationCode,
                Price = price
            };

            BaseResponse<string?>? res = _repo.CreateExitHistory(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }


        public void CreateFineHistory(string entryHistoryId, string locationCode, int price, string name, string identity, string vehicleIdentity, string address, string description)
        {
            if (string.IsNullOrEmpty(entryHistoryId))
            {
                throw new Exception("Entry History Id cannot be blank.");
            }

            if (string.IsNullOrEmpty(locationCode))
            {
                throw new Exception("Location cannot be blank.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be blank.");
            }

            if (string.IsNullOrEmpty(identity))
            {
                throw new Exception("Identity (KTP) cannot be blank.");
            }

            if (string.IsNullOrEmpty(vehicleIdentity))
            {
                throw new Exception("Identity (SIM) cannot be blank.");
            }

            if (string.IsNullOrEmpty(address))
            {
                throw new Exception("Address cannot be blank.");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new Exception("Description cannot be blank.");
            }

            if (price <= 0)
            {
                throw new Exception("Price cannot be blank.");
            }

            var payload = new FineHistoryRequest()
            {
                EntryHistoryId = entryHistoryId,
                LocationCode = locationCode,
                Price = price,
                Address = address,
                Description = description,
                Identity = identity,
                Name = name,
                VehicleIdentity = vehicleIdentity,
            };

            BaseResponse<string?>? res = _repo.CreateFineHistory(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }

        public BaseResponse<int?>? CalculateHistory(string entryHistoryId, bool isFine)
        {
            if (string.IsNullOrEmpty(entryHistoryId))
            {
                throw new Exception("Entry History Id cannot be blank.");
            }

            var payload = new CalculateHistoryRequest
            {
                EntryHistoryId = entryHistoryId,
                IsFine = isFine
            };

            BaseResponse<int?>? res = _repo.CalculateHistory(payload);
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

        public BaseResponse<HistoryStatistic?>? HistoryStatistic(string timeFrequency)
        {
            BaseResponse<HistoryStatistic?>? res = _repo.HistoryStatistic(timeFrequency);
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
    }
}
