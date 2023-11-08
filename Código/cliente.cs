using System;

public class Cliente
{
    public string Nome { get; }
    public int Idade { get; }
    public string CPF { get; }
    public string Entrada { get; set; }
    public string PratoPrincipal { get; set; }
    public string Sobremesa { get; set; }
    public float PrecoTotal { get; set; }

    public Cliente(string nome, int idade, string cpf)
    {
        if (idade <= 0 || idade >= 120)
        {
            throw new ArgumentException("A idade deve ser um número positivo e menor que 120 anos.");
        }

        if (cpf.Length != 11)
        {
            throw new ArgumentException("O CPF deve ter 11 dígitos.");
        }

        Nome = nome;
        Idade = idade;
        CPF = cpf;
        Entrada = "";
        PratoPrincipal = "";
        Sobremesa = "";
        PrecoTotal = 0.0f;
    }
}
