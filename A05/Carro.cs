using System;
using System.Runtime.CompilerServices;

namespace A05;

/*
  ok a classe carro tem as seguintes características:
  marca, modelo, velocidade

  ok para criar um carro, vc precisa informar a marca e 
  o modelo

  ok você pode alterar os dados da marca e modelo
  mas não pode alterar a velocidade, apenas ler
  a velocidade atual

  a classe tem 4 métodos/comportamentos:
  - ligar
  - acelerar (só pode acelerar se o carro estiver ligado)
  - freiar (só pode freiar se o carro estiver em movimento)
  - desligar

  obs: 
  a cada acelerada, o carro aumenta em 5km/h
  a cada freiada, o carro diminui 5km/h
*/

public class Carro
{
    // atributos
    private string marca;
    private string modelo;
    private int velocidade;
    private bool ligado;
    private const int VELOCIDADE_MAXIMA = 200;

    // construtor
     public Carro(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    // propriedades
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int Velocidade
    {
        get { return velocidade; }
    }

    // métodos
    public void Ligar()
    {
        ligado = true;
    }

    public void Acelerar()
    {
        if (ligado && velocidade < VELOCIDADE_MAXIMA) {
            velocidade = velocidade + 5;
        }
    }

    public void Freiar()
    {
        if (velocidade > 0) {
            velocidade -= 5;
        }
    }

    public void Desligar()
    {
        if (velocidade == 0)
            ligado = false;
    }
}
