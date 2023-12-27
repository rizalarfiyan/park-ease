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
        
        
        public BaseResponse<BaseResponsePagination<User?>>? GetAllUser(BaseRequestPagination param)
        {
            var req = new RestRequest("/user", Method.Get);
            param.Build(req);
            var res = _api.Execute<BaseResponse<BaseResponsePagination<User?>>?>(req);
            return res.Data;
        }
        
        public BaseResponse<User?>? GetUserById(int id)
        {
            var req = new RestRequest("/user/{id}", Method.Get);
            req.AddUrlSegment("id", id);
            var res = _api.Execute<BaseResponse<User?>?>(req);
            return res.Data;
        }
        
        public BaseResponse<string?>? CreateUser(UserRequest payload)
        {
            var req = new RestRequest("/user", Method.Post);
            req.AddJsonBody(new
            {
                username = payload.Username,
                password = payload.Password,
                name = payload.Name,
                role = payload.Role,
                status = payload.Status,
            });
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }
        
        public BaseResponse<string?>? UpdateUser(UserRequest payload)
        {
            var req = new RestRequest("/user/{id}", Method.Put);
            req.AddUrlSegment("id", payload.Id);
            req.AddJsonBody(new
            {
                username = payload.Username,
                name = payload.Name,
                role = payload.Role,
                status = payload.Status,
            });
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }
        
        public BaseResponse<string?>? DeleteUser(int id)
        {
            var req = new RestRequest("/user/{id}", Method.Delete);
            req.AddUrlSegment("id", id);
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }
    }
}
