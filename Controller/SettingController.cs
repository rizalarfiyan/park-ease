using ParkEase.Model.Entity;
using ParkEase.Model.Repository;
using ParkEase.Model.Response;

namespace ParkEase.Controller
{
    public class SettingController
    {
        private SettingRepository _repo;

        public SettingController()
        {
            _repo = new SettingRepository();
        }

        public BaseResponse<Setting>? GetSetting()
        {
            var res = _repo.GetSetting();
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

        public void CreateOrUpdateSetting(string fineTicketCalculationTxt, string nextHourCalculationTxt, string maxCapacityTxt)
        {
            if (string.IsNullOrEmpty(fineTicketCalculationTxt))
            {
                throw new Exception("Fine Ticket Calculation cannot be blank.");
            }

            if (string.IsNullOrEmpty(nextHourCalculationTxt))
            {
                throw new Exception("Next Hour Calculation cannot be blank.");
            }

            if (string.IsNullOrEmpty(maxCapacityTxt))
            {
                throw new Exception("Max Capacity Calculation cannot be blank.");
            }


            int fineTicketCalculation = 0;
            try
            {
                fineTicketCalculation = Int32.Parse(fineTicketCalculationTxt);
            }
            catch (FormatException)
            {
                throw new Exception("Fine Ticket Calculation not valid number type.");
            }

            int nextHourCalculation = 0;
            try
            {
                nextHourCalculation = Int32.Parse(nextHourCalculationTxt);
            }
            catch (FormatException)
            {
                throw new Exception("Next Hour Calculation not valid number type.");
            }

            int maxCapacity = 0;
            try
            {
                maxCapacity = Int32.Parse(maxCapacityTxt);
            }
            catch (FormatException)
            {
                throw new Exception("Max Capacity not valid number type.");
            }

            var payload = new SettingRequest()
            {
                FineTicketCalculation = fineTicketCalculation,
                NextHourCalculation = nextHourCalculation,
                MaxCapacity = maxCapacity,
            };

            BaseResponse<string?>? res = _repo.CreateOrUpdateSetting(payload);
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
