using System;

public class NotaFiscal
{
    public static Cardapio cardapio = new Cardapio();
    private Cliente cliente;
    private int mesaSelecionada;
    private string entradaEscolhida;
    private string pratoPrincipalEscolhido;
    private string sobremesaEscolhida;
    private float precoTotal;
  

    public NotaFiscal(Cliente cliente, int mesaSelecionada, string entradaEscolhida, string pratoPrincipalEscolhido, string sobremesaEscolhida, float precoTotal)
    {
        this.cliente = cliente;
        this.mesaSelecionada = mesaSelecionada;
        this.entradaEscolhida = entradaEscolhida;
        this.pratoPrincipalEscolhido = pratoPrincipalEscolhido;
        this.sobremesaEscolhida = sobremesaEscolhida;
        this.precoTotal = precoTotal;
    }

    public void ImprimirNotaFiscal()
    {
        Console.Clear();
        Console.WriteLine("=====================================================");
        Console.WriteLine("===             Nota Fiscal do Restaurante         ===");
        Console.WriteLine("=====================================================");

        Console.WriteLine($"Nome do Cliente: {cliente.Nome}");
        Console.WriteLine($"Idade: {cliente.Idade}");
        Console.WriteLine($"CPF: {cliente.CPF}");
        Console.WriteLine($"Mesa: {mesaSelecionada}");
        if (!string.IsNullOrEmpty(entradaEscolhida))
        {
            Console.WriteLine($"Entrada: {entradaEscolhida}");
        }
        if (!string.IsNullOrEmpty(pratoPrincipalEscolhido))
        {
            Console.WriteLine($"Prato Principal: {pratoPrincipalEscolhido}");
        }
        if (!string.IsNullOrEmpty(sobremesaEscolhida))
        {
            Console.WriteLine($"Sobremesa: {sobremesaEscolhida}");
        }

        Console.WriteLine($"Preço Total:{precoTotal:0.00}");

        Console.WriteLine("=====================================================");
        Console.WriteLine("===                Obrigado por vir!               ===");
        Console.WriteLine("=====================================================");
    }
}