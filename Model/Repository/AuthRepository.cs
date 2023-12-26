using ParkEase.Libs;
using ParkEase.Model.Response;
using ParkEase.Model.Entity;
using RestSharp;

namespace ParkEase.Model.Repository
{
    public class AuthRepository
    {
        private RestClient _api;
        public AuthRepository()
        {
            _api = new Api().Get();
        }

        public async Task<BaseResponse<User>?> Me()
        {
            var req = new RestRequest("/auth/me", Method.Get);
            var res = await _api.ExecuteAsync<BaseResponse<User>>(req);
            return res.Data;
        }
    }
}
