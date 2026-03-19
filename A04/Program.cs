using A04;

// criando o objeto produto do tipo Produto
// instanciando a classe Produto
var produto = new Produto("TV LCD", 1999.99);

// estado incosistente: 
// não existe no mundo real
// produto.descricao = "TV LCD";
// produto.quantidade = 100;

produto.comprar();
produto.comprar(2);
produto.comprar(3, 1002.59);