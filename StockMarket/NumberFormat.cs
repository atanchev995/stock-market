using System.Globalization;

namespace StockMarket
{
    class NumberFormat
    {
        public string ToUSString(double value)
        {
            return value.ToString(CultureInfo.GetCultureInfo("en-US"));
        }
    }
}
