using System;

namespace A04;

public class Produto
{
    // atributos
    private string? descricao;
    private int quantidade;
    private double valor;

    // construtores : tipo especial de método
    public Produto()
    {
        // estado inicial do objeto
        descricao = null;
        quantidade = 0;
        valor = 0;
    }

    public Produto(string descricao, double valor)
    {
        // o atributo descricao deve receber
        // o valor do parametro descricao
        this.descricao = descricao;
        quantidade = 0;
        this.valor = valor;
    }

    // métodos
    public void comprar()
    {
        this.quantidade++;
    }

    public void comprar(int qtd)
    {
        // quantidade = quantidade + qtd;
        this.quantidade += qtd;
    }

    public void comprar(int qtd, double valor)
    {
        this.quantidade += qtd;
        this.valor = valor;
    }

    public void vender()
    {
        
    }
}
