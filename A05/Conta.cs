using System;

namespace A05;

public class Conta
{
    // atributos
    private string? titular;
    private decimal saldo;
    private bool ativo;

    // construtor
    public Conta(string titular)
    {
        this.titular = titular;
    }

    // métodos
    public void depositar(decimal valor)
    {
        saldo = saldo + valor;
    }

    // porteiros: getters e setters
    // get: retornar a informaçao de um atributo
    // sintaxe: public [tipo] getAtributo() { }
    public string? getTitular()
    {
        return titular;
    }

    public decimal getSaldo()
    {
        return saldo;
    }

    // set: atribuir um valor a um atributo
    // sintaxe: public void setAtributo([tipo] valor) { }
    public void setTitular(string valor)
    {
        titular = valor;
    }
}
