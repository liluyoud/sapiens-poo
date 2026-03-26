using System;

namespace A05;

public class Aluno
{
    // atributos
    private string? nome;
    private string? sexo;

    // propriedades: get / set
    // sintaxe: public [tipo] Atributo {
    //             get { } 
    //             set { }
    //          }

    public string? Nome
    {
        get { return "Aluno " + nome; }
        set { nome = value + " da Sapiens"; }
    }
}
