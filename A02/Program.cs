using static System.Console;
using A02;

WriteLine("Classes e Objetos");

// declarar a variável x do tipo int
int x = 10;

// declarar a variável y do tipo string
string y;
y = "oi";

// declarar o objeto z do tipo Aluno
Aluno z;
// criar o objeto (alocar espaço na memória)
z = new Aluno();

// declarando e instanciando uma classe
// declarando e criando um objeto
Aluno w = new Aluno();
w.nome = "Pedro";
w.idade = 18;
w.email = "pedro@mail.com";
w.n1 = 8;
w.n2 = 7;
WriteLine($"A média do aluno {w.nome} é {w.media}");

Professor p1 = new Professor();
Disciplina d1 = new Disciplina();

ReadKey();