namespace Biblioteca
{
    public class Professor : UsuarioBiblioteca
    {
        public string Departamento { get; set; }

        public Professor(string nome, int quantidadeEmprestimosAtivos, string departamento)
            : base(nome, quantidadeEmprestimosAtivos)
        {
            Departamento = departamento;
        }
    }
}
