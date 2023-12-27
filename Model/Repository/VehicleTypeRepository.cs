using ParkEase.Libs;
using ParkEase.Model.Entity;
using ParkEase.Model.Response;
using RestSharp;

namespace ParkEase.Model.Repository
{
    public class VehicleTypeRepository
    {
        private RestClient _api;
        public VehicleTypeRepository()
        {
            _api = new Api().Get();
        }

        public BaseResponse<BaseResponsePagination<VehicleType>>? GetAllVehicleType(BaseRequestPagination param)
        {
            var req = new RestRequest("/vehicle_type", Method.Get);
            param.Build(req);
            var res = _api.Execute<BaseResponse<BaseResponsePagination<VehicleType>>?>(req);
            return res.Data;
        }
    }
}
