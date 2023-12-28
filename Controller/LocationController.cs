using ParkEase.Model.Entity;
using ParkEase.Model.Repository;
using ParkEase.Model.Response;

namespace ParkEase.Controller
{
    public class LocationController
    {
        private LocationRepository _repo;

        public LocationController()
        {
            _repo = new LocationRepository();
        }

        public BaseResponse<BaseResponsePagination<Location>>? GetAllLocation(BaseRequestPagination param)
        {
            var res = _repo.GetAllLocation(param);
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

        public void CreateLocation(string code, string name, bool isExit)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception("Code cannot be blank.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be blank.");
            }

            var payload = new Location()
            {
                Code = code,
                Name = name,
                IsExit = isExit,
            };

            BaseResponse<string?>? res = _repo.CreateLocation(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }

        public void UpdateLocation(string code, string name, bool isExit)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception("Code cannot be blank.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be blank.");
            }

            var payload = new Location()
            {
                Code = code,
                Name = name,
                IsExit = isExit,
            };

            BaseResponse<string?>? res = _repo.UpdateLocation(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }

        public void DeleteLocation(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception("Code cannot be blank.");
            }

            BaseResponse<string?>? res = _repo.DeleteLocation(code);
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
