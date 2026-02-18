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
        if (nome != null && nome != "")
        {
            _nome = nome;
        }
        else
        {
            _nome = "Aluno";
        }

        if (nota1 >= 0.0 && nota1 <= 30.0)
        {
            Nota1 = nota1;
        }
        else
        {
            Nota1 = 20.0;
        }

        if (nota2 >= 0.0 && nota2 <= 35.0)
        {
            Nota2 = nota2;
        }
        else
        {
            Nota2 = 20.0;
        }

        if (nota3 >= 0.0 && nota3 <= 35.0)
        {
            Nota3 = nota3;
        }
        else
        {
            Nota3 = 20.0;
        }
    }

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
        if (value != null && value != "")
            {
                _nome = value;
            }
        }
    }

    public Aluno(string nome) : this(nome, 20.0, 20.0, 20.0) {}

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