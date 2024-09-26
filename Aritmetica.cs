using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
	/// <summary>
	/// Implementa operações aritméticas.
	/// </summary>
    internal static class Aritmetica
    {
		/// <summary>
		/// Operação soma.
		/// </summary>
		/// <returns>Retorna a soma de dois números.</returns>
        public static int  Somar(int x, int y)
        {
            return x + y;
        }
		/// <summary>
		/// Operação subtração.
		/// </summary>
  		/// <returns>Retorna a subtração de dois números.</returns>
      public static int  Subtrair(int x, int y)
        {
            return x - y;
        }
		/// <summary>
		/// Operação multiplicação.
		/// </summary>
  		/// <returns>Retorna a multiplicação de dois números.</returns>
      public static int  Multiplicar(int x, int y)
        {
            return x * y;
        }
				/// <summary>
		/// Operação duplicação.
		/// </summary>
  		/// <returns>Retorna o dobro do número.</returns>
      public static int  Duplica(int y)
        {
            return 2 * y;
        }

    }
}
