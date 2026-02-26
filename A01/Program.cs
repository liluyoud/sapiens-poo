using static System.Console;

CriarMenu();

// variáveis e tipos de dados
int idade = 10;
string nome = "Lilo";
double salario = 1000.21;
bool casado = true;

var email = "lilo@mail.com";

// IO
WriteLine("Olá pessoal");
Write("Meu nome é ");
WriteLine(nome);

// Interpolação de strings
// Olá, meu nome é Lilo e tenho 10 anos de idade
WriteLine("Olá, meu nome é " + nome + " e tenho " + idade + " anos de idade");
WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos de idade");

// ler uma informação do usuário
Write("Informe seu telefone: ");
string telefone = ReadLine();
WriteLine($"Confirma que seu telefone é {telefone}?");

Write("Informe seu média: ");
double media = Convert.ToDouble(ReadLine());
WriteLine($"O dobro da média é {media + media}");

// decisão
if (casado == true && idade >= 18) {
	WriteLine($"O {nome} é casado");
} else {
	WriteLine($"O {nome} não é casado");
}

for (int i = 0; i < 10; i++) {
	WriteLine($"Contando {i} vezes");
}

while (idade < 18) {
	WriteLine($"O {nome} tem {++idade} anos de idade");
}

ReadKey();

void CriarMenu() {
	WriteLine("----------------------");
	WriteLine(" APRENDENDO C#");
	WriteLine("----------------------");
}


