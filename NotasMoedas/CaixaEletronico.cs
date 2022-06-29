using System.Globalization;
namespace NotasMoedas
{
    class CaixaEletronico
    {
        public decimal Valor { get; set; }
        public int NotaCem { get; set; }
        public int NotaCinquenta { get; set; }
        public int NotaVinte { get; set; }
        public int NotaDez { get; set; }
        public int NotaCinco { get; set; }
        public int NotaDois { get; set; }
        public int MoedaUm { get; set; }
        public int MoedaCinquenta { get; set; }
        public int MoedaVinteCinco { get; set; }
        public int MoedaDez { get; set; }
        public int MoedaCinco { get; set; }
        public int MoedaZeroUm { get; set; }

        public CaixaEletronico(decimal valor)
        {
            Valor = valor;
        }

        public void CalculaNotas()
        {
            NotaCem = (int)Valor / 100;
            decimal resto = Valor - (NotaCem * 100);

            NotaCinquenta = (int)resto / 50;
            resto -= NotaCinquenta * 50;

            NotaVinte = (int)resto / 20;
            resto -= NotaVinte * 20;

            NotaDez = (int)resto / 10;
            resto -= NotaDez * 10;

            NotaCinco = (int)resto / 5;
            resto -= NotaCinco * 5;

            NotaDois = (int)resto / 2;
            resto -= NotaDois * 2;

            MoedaUm = (int)resto / 1;
            resto -= MoedaUm * 1;

            MoedaCinquenta = (int)(resto / 0.5M);
            resto -= MoedaCinquenta * 0.5M;

            MoedaVinteCinco = (int)(resto / 0.25M);
            resto -= MoedaVinteCinco * 0.25M;

            MoedaDez = (int)(resto / 0.1M);
            resto -= MoedaDez * 0.1M;

            MoedaCinco = (int)(resto / 0.05M);
            resto -= MoedaCinco * 0.05M;

            MoedaZeroUm = (int)(resto / 0.01M);
            resto -= MoedaZeroUm * 0.01M;
        }

        public override string ToString()
        {
            return $"NOTAS: \n" +
                $"{NotaCem.ToString(CultureInfo.InvariantCulture)} nota(s) de R$ 100.00\n" +
                $"{NotaCinquenta.ToString(CultureInfo.InvariantCulture)} nota(s) de R$ 50.00\n" +
                $"{NotaVinte.ToString(CultureInfo.InvariantCulture)} nota(s) de R$ 20.00\n" +
                $"{NotaDez.ToString(CultureInfo.InvariantCulture)} nota(s) de R$ 10.00\n" +
                $"{NotaCinco.ToString(CultureInfo.InvariantCulture)} nota(s) de R$ 5.00\n" +
                $"{NotaDois.ToString(CultureInfo.InvariantCulture)} nota(s) de R$ 2.00\n" +
                $"MOEDAS:\n" +
                $"{MoedaUm.ToString(CultureInfo.InvariantCulture)} moeda(s) de R$ 1.00\n" +
                $"{MoedaCinquenta.ToString(CultureInfo.InvariantCulture)} moeda(s) de R$ 0.50\n" +
                $"{MoedaVinteCinco.ToString(CultureInfo.InvariantCulture)} moeda(s) de R$ 0.25\n" +
                $"{MoedaDez.ToString(CultureInfo.InvariantCulture)} moeda(s) de R$ 0.10\n" +
                $"{MoedaCinco.ToString(CultureInfo.InvariantCulture)} moeda(s) de R$ 0.05\n" +
                $"{MoedaZeroUm.ToString(CultureInfo.InvariantCulture)} moeda(s) de R$ 0.01\n";
        }
    }
}
