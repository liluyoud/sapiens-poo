namespace A02;

public class Aluno
{
    // características ou atributos
    public string? nome;
    public int idade;
    private string? cpf;
    public string? email;
    public double n1;
    public double n2;
    public bool aprovado;

    // atributo derivado
    public double media => (n1 + n2) / 2;

    // comportamento

}
