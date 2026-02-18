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

    public static void ExemploConstrutores()
    {
        Console.WriteLine("Exemplo de uso de construtores");

        Console.WriteLine();
        Console.WriteLine("[Construtor Completo] — Entre com os dados do primeiro aluno:");
        Aluno a1 = AlunoInputs.CriarAluno();

        Console.WriteLine();
        Console.Write("[Construtor Parcial] — Entre com o nome do segundo aluno: ");
        string nome = Console.ReadLine()!;
        Aluno a2 = new(nome);

        Console.WriteLine();
        Console.WriteLine(a1.ToString());
        Console.WriteLine();
        Console.WriteLine(a2.ToString());
    }
}