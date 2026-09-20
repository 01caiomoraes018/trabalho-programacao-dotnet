using System.Globalization;

namespace ReservaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reserva reserva = new Reserva
            {
                Id = 1,
                NomeHospede = "Caio Moraes",
                NumeroQuarto = 203,
                QuantidadeDiarias = 3,
                ValorDiaria = 180.00m,
                StatusInterno = "CONFIRMADA",
                ObservacaoInterna = "Conferencia realizada pela recepcao."
            };

            RelatorioReservaDto relatorio = Mapear(reserva);
            ExibirRelatorio(relatorio);
        }

        public static RelatorioReservaDto Mapear(Reserva reserva)
        {
            return new RelatorioReservaDto(
                reserva.NomeHospede,
                reserva.NumeroQuarto,
                reserva.QuantidadeDiarias,
                reserva.QuantidadeDiarias * reserva.ValorDiaria,
                "Reserva confirmada");
        }

        public static void ExibirRelatorio(RelatorioReservaDto relatorio)
        {
            Console.WriteLine("=== Relatorio da reserva ===");
            Console.WriteLine($"Hospede: {relatorio.NomeHospede}");
            Console.WriteLine($"Quarto: {relatorio.NumeroQuarto}");
            Console.WriteLine($"Quantidade de diarias: {relatorio.QuantidadeDiarias}");
            Console.WriteLine($"Valor total: {relatorio.ValorTotal.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}");
            Console.WriteLine($"Situacao: {relatorio.Situacao}");
        }
    }
}
