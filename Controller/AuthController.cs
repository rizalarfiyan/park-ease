using ParkEase.Model.Entity;
using ParkEase.Model.Repository;
using ParkEase.Model.Response;

namespace ParkEase.Controller
{
    public class AuthController
    {
        private AuthRepository _repo;

        public AuthController()
        {
            _repo = new AuthRepository();
        }

        public void Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Username cannot be blank.");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password cannot be blank.");
            }

            BaseResponse<AuthLogin>? res = _repo.Login(username, password);
            if (res == null || res.Data == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }

            //! Set session here
            Program.UserData = new User()
            {
                Id = res.Data.Id,
                Name = res.Data.Name,
                Role = res.Data.Role,
                Status = res.Data.Status,
                Username = res.Data.Username,
            };
        }
    }
}
