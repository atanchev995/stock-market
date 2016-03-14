using System.Globalization;

namespace StockMarket
{
    class NumberFormat
    {
        // declare variables
        private string usString;

        public string ToUSString(double val)
        {
            usString = val.ToString(CultureInfo.GetCultureInfo("en-US"));
            return usString;
        }
    }
}
