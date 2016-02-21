using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
