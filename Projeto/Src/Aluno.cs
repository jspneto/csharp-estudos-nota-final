using System.Globalization;

namespace Projeto.Src;

class Aluno
{
    public string Nome = "Aluno";
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double NotaFinal()
    {
        return Nota1 + Nota2 + Nota3;
    }

    public static bool Aprovacao(double nota)
    {
        if (nota >= 60.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        double notaFinal = NotaFinal();
        bool aprovacao = Aprovacao(notaFinal);

        string dadosAluno = $"Nome: {Nome}\n"
            + $"Nota Final: {notaFinal.ToString("F1", CultureInfo.InvariantCulture)}\n";

        if (aprovacao)
        {
            dadosAluno += "Situação: Aprovado";
        }
        else
        {
            dadosAluno += "Situação: Reprovado\n"
                + $"Faltam: {(60.0 - notaFinal).ToString("F1", CultureInfo.InvariantCulture)}";
        }

        return dadosAluno;
    }
}