using static System.Console;
using A05;


var carro = new Carro("BYD", "Dolphin");
carro.Marca = "GM";
carro.Ligar();
carro.Acelerar();
carro.Acelerar();
carro.Freiar();
carro.Freiar();
carro.Desligar();


Conta conta = new("Lilo");
WriteLine($"Titular: {conta.getTitular()}");
WriteLine($"Saldo:   {conta.getSaldo()}");

conta.setTitular("Liluyoud Cury de Lacerda");
WriteLine($"Titular: {conta.getTitular()}");


var aluno = new Aluno();
// aluno.setNome("Paulo");
aluno.Nome = "Paulo";
// WriteLine($"Aluno: {aluno.getNome()}");
WriteLine($"Aluno: {aluno.Nome}");

ReadLine();