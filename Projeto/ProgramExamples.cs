using Projeto.Src;
using Projeto.Src.IO;

namespace Projeto;

static class ProgramExamples
{
    public static void SolucaoProblema()
    {
        Console.WriteLine("Entre com os dados do aluno:");
        Aluno a = AlunoInputs.CriarAluno();

        Console.WriteLine();
        Console.WriteLine(a.ToString());
    }
}