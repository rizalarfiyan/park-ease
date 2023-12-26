using RestSharp;

namespace ParkEase.Libs
{
    public class Api
    {
        private RestClient _api;

        public Api()
        {
            _api = new RestClient(Constants.App.API_BASE_URL);
        }

        public RestClient Get()
        {
            //! FIX ME LATER add header
            _api.AddDefaultHeader("Content-Type", "application/json");
            _api.AddDefaultHeader("Accept", "application/json");
            return _api;
        }
    }
}
