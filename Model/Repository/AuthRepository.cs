using ParkEase.Libs;
using ParkEase.Model.Response;
using RestSharp;

namespace ParkEase.Model.Repository
{
    public class AuthRepository
    {
        private RestClient _api;
        public AuthRepository() {
            _api = new Api().Get();
        }

        public BaseResponse<UserResponse> Me()
        {
            var req = new RestRequest("auth/me", Method.Get);
            var res = _api.Execute<BaseResponse<UserResponse>>(req);
            return new BaseResponse<UserResponse>(res);
        }
    }
}
