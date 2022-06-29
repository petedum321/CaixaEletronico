using System;
using System.Globalization;

namespace NotasMoedas
{
    class Program
    {
        static void Main(string[] args)
        {           
            try
            {
                decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);              

                CaixaEletronico caixaEletronico = new CaixaEletronico(valor);

                caixaEletronico.CalculaNotas();

                Console.WriteLine(caixaEletronico);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
