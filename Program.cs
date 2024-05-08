class Aluno
{
    private int matricula;
    private string nome;

    public Aluno(int matricula, string nome)
    {
        this.matricula = matricula;
        this.nome = nome;
    }

    public int Matricula { get => matricula; }
    public string Nome { get => nome; }

    public void Apresentar()
    {
        Console.WriteLine($"Aluno: {nome} (Matrícula: {matricula})");
    }
}

class Turma
{
    private string codigo;
    private string curso;
    private List<Aluno> alunos;

    public Turma(string codigo, string curso)
    {
        this.codigo = codigo;
        this.curso = curso;
        alunos = new List<Aluno>();
    }

    public string Codigo { get => codigo; }
    public string Curso { get => curso; }
    public List<Aluno> Alunos { get => alunos; }

    public void MatricularAluno(Aluno aluno)
    {
        alunos.Add(aluno);
    }

    public void MostrarAlunos()
    {
        Console.WriteLine($"Turma: {codigo} ({curso})");
        foreach (Aluno aluno in alunos)
        {
            aluno.Apresentar();
        }
    }


    Aluno aluno1 = new Aluno(101, "João Silva");
    Aluno aluno2 = new Aluno(102, "Maria Gomes");

    Turma turmaA = new Turma("T-001", "Informática");
    Turma turmaB = new Turma("T-002", "Administração");

    turmaA.MatricularAluno(aluno1);
    turmaA.MatricularAluno(aluno2);

    turmaB.MatricularAluno(aluno1); // Sobrecarga de MatricularAluno

    turmaA.MostrarAlunos();
    turmaB.MostrarAlunos();

}

