using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MD5

            string Nome = "C# Brasil";
            string MD5 = Nome.ToMD5();

            Console.WriteLine(MD5);

            #endregion

            #region Calcula IPI

            decimal Valor = 580.78M;
            decimal Perc = 2;

            decimal IPI = Valor.CalcularIPI(Perc);

            Console.WriteLine(IPI.ToString());

            #endregion

            #region Abreviar Nome

            var nome1 = "Lucas Magno Veiga Silva";
            var nome2 = "Jose Antonio da Silva";

            Console.WriteLine(nome1.Abreviacao());
            Console.WriteLine(nome2.Abreviacao());

            #endregion

            Console.ReadKey();
        }
    }
}
