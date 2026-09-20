namespace Biblioteca
{
    public class Visitante : UsuarioBiblioteca
    {
        public string Documento { get; set; }

        public Visitante(string nome, int quantidadeEmprestimosAtivos, string documento)
            : base(nome, quantidadeEmprestimosAtivos)
        {
            Documento = documento;
        }
    }
}
