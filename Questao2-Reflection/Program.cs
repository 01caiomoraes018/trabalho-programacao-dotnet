using System.Reflection;

namespace ReflectionEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipamento equipamento = new Equipamento
            {
                Id = 1,
                Nome = "Notebook",
                Fabricante = "Dell",
                NumeroSerie = "EXEMPLO001",
                Valor = 3500.00m,
                Localizacao = "Laboratorio 1"
            };

            Console.WriteLine("=== Reflection aberta ===");
            ExibirDadosAberto(equipamento);

            Console.WriteLine("\n=== Reflection controlada ===");
            ExibirDadosControlado(equipamento);
        }

        public static void ExibirDadosAberto(object objeto)
        {
            Type tipo = objeto.GetType();

            foreach (var propriedade in tipo.GetProperties())
            {
                object? valor = propriedade.GetValue(objeto);
                Console.WriteLine($"{propriedade.Name}: {valor}");
            }
        }

        public static void ExibirDadosControlado(object objeto)
        {
            Type tipo = objeto.GetType();

            foreach (var propriedade in tipo.GetProperties())
            {
                // Somente as propriedades marcadas com Exibir entram nesta saída.
                if (propriedade.GetCustomAttribute<ExibirAttribute>() != null)
                {
                    object? valor = propriedade.GetValue(objeto);
                    Console.WriteLine($"{propriedade.Name}: {valor}");
                }
            }
        }
    }
}
