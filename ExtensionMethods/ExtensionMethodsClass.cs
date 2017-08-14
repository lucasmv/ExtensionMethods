using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class ExtensionMethodsClass
    {
        public static string ToMD5(this string value)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes(value);
            byte[] hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));

            return sb.ToString();
        }

        public static decimal CalcularIPI(this decimal value, decimal percentual)
        {
            decimal Total = decimal.Divide(decimal.Multiply(value, percentual), 100);
            return Total;
        }

        public static string Abreviacao(this string value)
        {
            var  pattern = "(de\\.? |do\\.? |dos |da\\.? |das\\.? )";

            var nome = Regex.Replace(value, pattern, string.Empty);
            var nomeAbreviado = string.Empty;
            var nomeQuebrado = nome.Split(' ');

            foreach (var item in nomeQuebrado)
                nomeAbreviado += item[0] + " ";

            return nomeAbreviado;
        }
    }
}
