using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termologia
{
    public static class CalcularTemperatura
    {
        public static double CelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
    }
}
