namespace Biblioteca
{
    public class UsuarioBiblioteca
    {
        public string Nome { get; set; }
        public int QuantidadeEmprestimosAtivos { get; set; }

        public UsuarioBiblioteca(string nome, int quantidadeEmprestimosAtivos)
        {
            Nome = nome;
            QuantidadeEmprestimosAtivos = quantidadeEmprestimosAtivos;
        }
    }
}
