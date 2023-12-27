using ParkEase.Libs;
using ParkEase.Model.Entity;
using ParkEase.Model.Response;
using RestSharp;

namespace ParkEase.Model.Repository
{
    public class UserRepository
    {
        private RestClient _api;
        public UserRepository()
        {
            _api = new Api().Get();
        }

        public BaseResponse<string?>? ChangePassword(ChangePasswordRequest payload)
        {
            var req = new RestRequest("/user/change-password", Method.Post);
            req.AddJsonBody(new
            {
                old_password = payload.OldPassword,
                password = payload.Password,
                password_confirmation = payload.PasswordConfirmation,
            });
            var res = _api.Execute<BaseResponse<string?>>(req);
            return res.Data;
        }
    }
}
