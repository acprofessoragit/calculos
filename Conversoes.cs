﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversoes
{
	/// <summary>
	/// Implementa operações de conversão.
	/// </summary>
    internal static class Conversoes
    {
		/// <summary>
		/// Tipo de conversão de temperatura a utilizar.
		/// </summary>
		public enum ConversaoTemperatura
		{
			Nulo = 0,
			CelsiusFahrenheit,
			FahrenheitCelsius 
		}
		/// <summary>
		/// Converte a temperatura.
		/// </summary>
		/// <returns>Retorna a soma de dois números.</returns>
       }
      public static double  ConverterTemperatura(ConversaoTemperatura conversao, ConversaoTemperatura temperatura)
        {
			if ( conversao == ConversaoTemperatura.CelsiusFahrenheit)
			{
				return (temperatura* 1.8000 + 32);
			}
			else if ( conversao == ConversaoTemperatura.FahrenheitCelsius)
			{
				return ((temperatura - 32)/ 1.8000);
			}
			return -1;
		
        }
    }
}