using ParkEase.Libs;
using ParkEase.Model.Entity;
using ParkEase.Model.Response;
using RestSharp;

namespace ParkEase.Model.Repository
{
    public class SettingRepository
    {
        private RestClient _api;
        public SettingRepository()
        {
            _api = new Api().Get();
        }

        public BaseResponse<Setting>? GetSetting()
        {
            var req = new RestRequest("/setting", Method.Get);
            var res = _api.Execute<BaseResponse<Setting>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? CreateOrUpdateSetting(SettingRequest payload)
        {
            var req = new RestRequest("/setting", Method.Post);
            req.AddJsonBody<SettingRequest>(payload);
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }
    }
}
