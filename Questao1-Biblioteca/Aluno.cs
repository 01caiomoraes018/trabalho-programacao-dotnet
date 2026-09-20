namespace Biblioteca
{
    public class Aluno : UsuarioBiblioteca
    {
        public string Matricula { get; set; }

        public Aluno(string nome, int quantidadeEmprestimosAtivos, string matricula)
            : base(nome, quantidadeEmprestimosAtivos)
        {
            Matricula = matricula;
        }
    }
}
