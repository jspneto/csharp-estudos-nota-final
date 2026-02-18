# Cáculo da Nota Final

Programa para calcular a nota final de um aluno com base nas três notas trimestrais e informar sua situação no ano letivo.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código em uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Implementação procedural (quando solicitado)
- Classes, métodos e sobrescrita (Override)
- Métodos e classes estáticas (quando aplicável)
- Construtores e sobrecarcaga (Overload)
- Encapsulamento, Properties e Auto-Properties (quando aplicável)

## Enunciado do Projeto

O programa deve ler o nome de um aluno e as três notas obtidas ao longo do ano. Cada trimestre possui um peso específico: o primeiro vale 30 pontos, enquanto o segundo e o terceiro valem 35 pontos cada.

Ao final, o sistema deve:

- Calcular a nota final do aluno no ano.
- Informar se o aluno está aprovado ou reprovado.
- Caso esteja reprovado, calcular e exibir quantos pontos faltaram para atingir a média mínima de 60 pontos.

## Estrutura do Projeto

```bash
|- Projeto/
   |- Img/
   |- Src/
      |- IO/
         |- AlunoInputs.cs
      |- Aluno.cs
   |- Program.cs
   |- ProgramExamples.cs
   |- Projeto.csproj
   |- Projeto.sln
   |- README.md
```

*(A estrutura pode evoluir conforme o aprendizado avança.)*

## Evolução do Projeto (Tags)

- [**v0.1**][1] — Classe Aluno com calculo da nota final e override de ToString

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

[1]: https://github.com/jspneto/csharp-estudos-nota-final/tree/v0.1/Projeto "v0.1"
