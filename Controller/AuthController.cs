using ParkEase.Model.Entity;
using ParkEase.Model.Repository;
using ParkEase.Model.Response;

namespace ParkEase.Controller
{
    public class AuthController
    {
        private AuthRepository _repo;

        private readonly string persistanceAuthLocation = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) ?? "./", ".persistanceauth");

        public AuthController()
        {
            _repo = new AuthRepository();
        }

        public string? GetPersistanceAuth()
        {
            try
            {
                string? getUserToken = File.ReadLines(persistanceAuthLocation).FirstOrDefault();
                if (getUserToken != null)
                {
                    return getUserToken;
                }
            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.Print($"An error occurred while writing to the file: {e.Message}");
            }

            return null;
        }

        public void SetPersistanceAuth(string userToken)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(persistanceAuthLocation, false))
                {
                    writer.Write(userToken);
                }
            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.Print($"An error occurred while writing to the file: {e.Message}");
            }
        }

        public void RemovePersistanceAuth()
        {
            try
            {
                if (File.Exists(persistanceAuthLocation))
                {
                    File.Delete(persistanceAuthLocation);
                    System.Diagnostics.Debug.Print("File successfully deleted.");
                }
                else
                {
                    System.Diagnostics.Debug.Print("File does not exist.");
                }
            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.Print($"An error occurred while writing to the file: {e.Message}");
            }
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
            if (res == null)
            {
                throw new Exception("Something wrong for your request");
            }

            if (res.IsErrorConfirmation())
            {
                throw new Exception(res.Message);
            }

            if (res.Data == null)
            {
                throw new Exception("Something wrong for your request");
            }

            SetPersistanceAuth(res.Data.Token);
            Program.UserToken = res.Data.Token;
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
