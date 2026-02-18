using System.Globalization;

namespace Projeto.Src.IO;

static class AlunoInputs
{
    public static Aluno CriarAluno()
    {
        Aluno a = new();

        Console.Write("Nome: ");
        a.Nome = Console.ReadLine()!;
        Console.Write("Nota da 1ª avaliação: ");
        a.Nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Nota da 2ª avaliação: ");
        a.Nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Nota da 3ª avaliação: ");
        a.Nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        return a;
    }
}