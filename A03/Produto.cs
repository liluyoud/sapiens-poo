using System;

namespace A03;

public class Produto
{
    // atributos ou características
    public string? descricao;
    public int quantidade;
    public double valor;

    // métodos ou comportamento
    public void comprar()
    {
        // quantidade = quantidade + 1;
        // quantidade += 1;
        quantidade++;
    }

    public void vender()
    {
        if (quantidade > 0)
            quantidade--;
        else throw new Exception("Estoque indisponível");
    }

    public void devolver()
    {
        
    }

    public double calcularImposto()
    {
        var imposto = valor * 0.17; // 17%
        return imposto;
    }

}
