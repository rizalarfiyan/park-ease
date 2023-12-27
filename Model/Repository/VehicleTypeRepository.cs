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

        public BaseResponse<VehicleType>? GetVehicleTypeByCode(string code)
        {
            var req = new RestRequest("/vehicle_type/{code}", Method.Get);
            req.AddUrlSegment("code", code);
            var res = _api.Execute<BaseResponse<VehicleType>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? CreateVehicleType(VehicleType payload)
        {
            var req = new RestRequest("/vehicle_type", Method.Post);
            req.AddJsonBody(new
            {
                name = payload.Name,
                code = payload.Code,
                price = payload.Price,
            });
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? UpdateVehicleType(VehicleType payload)
        {
            var req = new RestRequest("/vehicle_type/{code}", Method.Put);
            req.AddUrlSegment("code", payload.Code);
            req.AddJsonBody(new
            {
                name = payload.Name,
                price = payload.Price,
            });
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? DeleteVehicleType(string code)
        {
            var req = new RestRequest("/vehicle_type/{code}", Method.Delete);
            req.AddUrlSegment("code", code);
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }
    }
}
