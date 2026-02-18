using System.Globalization;

namespace Projeto.Src.IO;

static class AlunoInputs
{
    public static Aluno CriarAluno()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Nota da 1ª avaliação: ");
        double nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Nota da 2ª avaliação: ");
        double nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Nota da 3ª avaliação: ");
        double nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Aluno a = new(nome, nota1, nota2, nota3);

        return a;
    }
}