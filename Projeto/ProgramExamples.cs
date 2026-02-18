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
        Console.WriteLine("Exemplo de uso de Construtores");

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

    public static void ExemploEncapsulamento()
    {
        Console.WriteLine("Exemplo de uso de Encapsulamento");
        
        Console.WriteLine();
        Console.WriteLine("Entre com os dados do aluno:");
        Aluno a = AlunoInputs.CriarAluno();
        Console.WriteLine();
        Console.WriteLine(a.ToString());

        Console.WriteLine();
        Console.Write("Corrija o nome do aluno: ");
        a.Nome = Console.ReadLine()!;
        Console.WriteLine();
        Console.WriteLine(a.ToString());
    }
}