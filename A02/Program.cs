using static System.Console;
using A02;


Aluno aluno = new();
aluno.n1 = 0;
WriteLine($"N1: {aluno.n1}");
WriteLine($"Aprovado: {aluno.aprovado}");
WriteLine($"Nome: {aluno.nome}");

if (aluno.nome == string.Empty)
{
    WriteLine("Vazio");
}

if (aluno.nome == null)
{
    WriteLine("Nulo");
}

ReadKey();

