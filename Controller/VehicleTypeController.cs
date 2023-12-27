using ParkEase.Model.Entity;
using ParkEase.Model.Repository;
using ParkEase.Model.Response;

namespace ParkEase.Controller
{
    public class VehicleTypeController
    {
        private VehicleTypeRepository _repo;

        public VehicleTypeController()
        {
            _repo = new VehicleTypeRepository();
        }

        public BaseResponse<BaseResponsePagination<VehicleType>>? GetAllVehicleType(BaseRequestPagination param)
        {
            var res = _repo.GetAllVehicleType(param);
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

        public void CreateVehicleType(string code, string name, string priceTxt)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception("Code cannot be blank.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be blank.");
            }

            if (string.IsNullOrEmpty(priceTxt))
            {
                throw new Exception("Price cannot be blank.");
            }

            int price = 0;
            try
            {
                price = Int32.Parse(priceTxt);
            }
            catch (FormatException)
            {
                throw new Exception("Price not valid number type.");
            }

            var payload = new VehicleType()
            {
                Code = code,
                Name = name,
                Price = price,
            };

            BaseResponse<string?>? res = _repo.CreateVehicleType(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }

        public void UpdateVehicleType(string code, string name, string priceTxt)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception("Code cannot be blank.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be blank.");
            }

            if (string.IsNullOrEmpty(priceTxt))
            {
                throw new Exception("Price cannot be blank.");
            }

            int price = 0;
            try
            {
                price = Int32.Parse(priceTxt);
            }
            catch (FormatException)
            {
                throw new Exception("Price not valid number type.");
            }

            var payload = new VehicleType()
            {
                Code = code,
                Name = name,
                Price = price,
            };

            BaseResponse<string?>? res = _repo.UpdateVehicleType(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }

        public void DeleteVehicleType(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception("Code cannot be blank.");
            }

            BaseResponse<string?>? res = _repo.DeleteVehicleType(code);
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
