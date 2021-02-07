using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TaxaJuros.API.Extensions
{
    /// <summary>
    /// Classe para conversão no formato decimal conforme a cultura pt-BR
    /// </summary>
    
    public static class DecimalExtensions
    {
        /// <summary>
        /// Método responsável para converter um decimal para o formato brasileiro
        /// </summary>
        public static string ToDecimal(this object value)
        {
            if (null == value)
                return null; 

            try
            {
                return Convert
                 .ToDecimal(value, CultureInfo.InvariantCulture)
                 .ToString("N", CultureInfo.GetCultureInfo("pt-BR"));
            }
            catch (FormatException)
            {
                return "0,00"; 
            }
        }
    }
}
