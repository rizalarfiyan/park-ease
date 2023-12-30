using ParkEase.Model.Entity;
using ParkEase.Model.Repository;
using ParkEase.Model.Response;

namespace ParkEase.Controller
{
    public class UserController
    {
        private UserRepository _repo;

        public UserController()
        {
            _repo = new UserRepository();
        }

        public BaseResponse<BaseResponsePagination<User>>? GetAllUser(BaseRequestPagination param)
        {
            var res = _repo.GetAllUser(param);
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

        public void CreateUser(string username, string password, string name, string role, string status)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Username cannot be blank.");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password cannot be blank.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be blank.");
            }

            if (string.IsNullOrEmpty(role))
            {
                throw new Exception("Role cannot be blank.");
            }

            if (string.IsNullOrEmpty(status))
            {
                throw new Exception("Status cannot be blank.");
            }

            var payload = new UserRequest()
            {
                Username = username,
                Password = password,
                Name = name,
                Role = role,
                Status = status
            };

            BaseResponse<string?>? res = _repo.CreateUser(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }

        public void UpdateUser(string username, string password, string name, string role, string status, int userId)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Username cannot be blank.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be blank.");
            }

            if (string.IsNullOrEmpty(role))
            {
                throw new Exception("Role cannot be blank.");
            }

            if (string.IsNullOrEmpty(status))
            {
                throw new Exception("Status cannot be blank.");
            }

            var payload = new UserRequest()
            {
                Id = userId,
                Username = username,
                Name = name,
                Role = role,
                Status = status
            };

            if (!string.IsNullOrEmpty(password))
            {
                payload.Password = password;
            }

            BaseResponse<string?>? res = _repo.UpdateUser(payload);
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }
        }

        public void ChangePassword(string oldPassword, string password, string passwordConfirmation)
        {
            if (string.IsNullOrEmpty(oldPassword))
            {
                throw new Exception("Old Password cannot be blank.");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password cannot be blank.");
            }

            if (string.IsNullOrEmpty(passwordConfirmation))
            {
                throw new Exception("Password Confirmation cannot be blank.");
            }

            var payload = new ChangePasswordRequest()
            {
                OldPassword = oldPassword,
                Password = password,
                PasswordConfirmation = passwordConfirmation
            };

            BaseResponse<string?>? res = _repo.ChangePassword(payload);
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
