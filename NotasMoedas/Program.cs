using System;

namespace NotasMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor = decimal.Parse(Console.ReadLine());

            CaixaEletronico caixaEletronico = new CaixaEletronico(valor);

            caixaEletronico.CalculaNotas();

            Console.WriteLine(caixaEletronico);
        }
    }
}
