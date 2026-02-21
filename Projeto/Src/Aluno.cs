using System.Globalization;

namespace Projeto.Src;

class Aluno
{
    private string _nome;
    public double Nota1 { get; private set; }
    public double Nota2 { get; private set; }
    public double Nota3 { get; private set; }

    public Aluno(string nome, double nota1, double nota2, double nota3)
    {
        if (NomeValido(nome))
        {
            _nome = nome;
        }
        else
        {
            _nome = "Aluno";
        }

        Nota1 = ValidarNota(nota1, 0.0, 30.0);
        Nota2 = ValidarNota(nota2, 0.0, 35.0);
        Nota3 = ValidarNota(nota3, 0.0, 35.0);
    }

    public Aluno(string nome) : this(nome, 20.0, 20.0, 20.0) {}

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
        if (NomeValido(value))
            {
                _nome = value;
            }
        }
    }

    private static bool NomeValido(string nome)
    {
        if (nome != null && nome != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static double ValidarNota(double nota, double min, double max)
    {
        if (nota >= min && nota <= max)
        {
            return nota;
        }
        else
        {
            return 20.0;
        }
    }

    public double NotaFinal()
    {
        return Nota1 + Nota2 + Nota3;
    }

    private static bool Aprovacao(double nota)
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