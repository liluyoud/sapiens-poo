using A03;
using static System.Console;

WriteLine("Trabalhando com métodos");

Produto produto = new();
produto.descricao = "TV LCD";
produto.quantidade = 0;
produto.valor = 1999.99;
produto.comprar();
WriteLine(produto.quantidade);

produto.vender();
WriteLine(produto.quantidade);

produto.devolver();

var imposto = produto.calcularImposto();
WriteLine(imposto.ToString("N2"));

ReadLine();