using System;

namespace NotasMoedas
{
    class Program
    {
        static void Main(string[] args)
        {           
            try
            {
                decimal valor = decimal.Parse(Console.ReadLine());

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
