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

        public BaseResponse<BaseResponsePagination<VehicleType>>? GetAllVehicleType(BaseRequestPagination param) {
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
    }
}
