namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Caio Moraes", 2, "2026001");
            Aluno alunoNoLimite = new Aluno("Ana", 3, "2026002");
            Professor professor = new Professor("Lucas", 4, "Tecnologia");
            Professor professorNoLimite = new Professor("Marina", 5, "Matematica");
            Visitante visitante = new Visitante("Pedro", 0, "VIS001");
            UsuarioBiblioteca usuario = new UsuarioBiblioteca("Joao", 0);

            Console.WriteLine(VerificarEmprestimo(aluno));
            Console.WriteLine(VerificarEmprestimo(alunoNoLimite));
            Console.WriteLine(VerificarEmprestimo(professor));
            Console.WriteLine(VerificarEmprestimo(professorNoLimite));
            Console.WriteLine(VerificarEmprestimo(visitante));
            Console.WriteLine(VerificarEmprestimo(null));
            Console.WriteLine(VerificarEmprestimo(usuario));
        }

        public static string VerificarEmprestimo(object? obj)
        {
            return obj switch
            {
                null => "Usuário inválido",
                Aluno { QuantidadeEmprestimosAtivos: < 3 } => "Empréstimo autorizado para aluno",
                Aluno { QuantidadeEmprestimosAtivos: >= 3 } => "Limite de empréstimos atingido para aluno",
                Professor { QuantidadeEmprestimosAtivos: < 5 } => "Empréstimo autorizado para professor",
                Professor { QuantidadeEmprestimosAtivos: >= 5 } => "Limite de empréstimos atingido para professor",
                Visitante => "Visitantes não podem realizar empréstimos",
                _ => "Usuário não classificado"
            };
        }
    }
}
