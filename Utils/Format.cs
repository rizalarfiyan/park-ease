using System.Globalization;

namespace ParkEase.Utils
{
    public static class Format
    {
        public static string FormatCurrencyIDR(int amount)
        {
            CultureInfo cultureIDR = new CultureInfo("id-ID");
            string formattedAmount = string.Format(cultureIDR, "{0:C}", amount);
            return formattedAmount;
        }
    }
}
