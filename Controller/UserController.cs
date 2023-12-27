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
