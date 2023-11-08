using System;

public class Restaurante
{
    private Mesa[] mesas;
    private Cardapio cardapio;

    public Restaurante()
    {
        mesas = new Mesa[5];
        for (int i = 0; i < mesas.Length; i++)
        {
            mesas[i] = new Mesa();
        }
        cardapio = new Cardapio();
    }

    public void ExecutarRestaurante()
    {
        Console.WriteLine("Bem-vindo ao restaurante!");
        Console.WriteLine("Por favor, informe seus dados:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Cliente cliente = new Cliente(nome, idade, cpf);

        Console.WriteLine("Selecione uma mesa disponível (0-4): ");
        int mesaSelecionada = int.Parse(Console.ReadLine());

        if (mesaSelecionada >= 0 && mesaSelecionada < mesas.Length)
        {
            if (!mesas[mesaSelecionada].MesaOcupada())
            {
                Console.WriteLine($"Você foi adicionado à mesa {mesaSelecionada}.");
                Console.WriteLine("Agora, selecione suas opções do cardápio:");
                cardapio.ExibirCardapio();

                int entradaIndex = EscolherOpcao("Escolha uma entrada (1-2): ", 2);
                int pratoPrincipalIndex = EscolherOpcao("Escolha um prato principal (3-4): ", 4);
                int sobremesaIndex = EscolherOpcao("Escolha uma sobremesa (5-6): ", 6);

                float precoTotal = cardapio.CalcularPrecoTotal(entradaIndex, pratoPrincipalIndex, sobremesaIndex);

                mesas[mesaSelecionada].AdicionarPessoa(cliente, cardapio.GetItemNome(entradaIndex), cardapio.GetItemNome(pratoPrincipalIndex), cardapio.GetItemNome(sobremesaIndex), precoTotal);
                Console.WriteLine("Pedido registrado com sucesso!");

              
              NotaFiscal notaFiscal = new NotaFiscal(cliente, mesaSelecionada, cardapio.GetItemNome(entradaIndex), cardapio.GetItemNome(pratoPrincipalIndex), cardapio.GetItemNome(sobremesaIndex), precoTotal);

              notaFiscal.ImprimirNotaFiscal();
            }
            else
            {
                Console.WriteLine($"Desculpe, a mesa {mesaSelecionada} já está ocupada.");
            }
        }
        else
        {
            Console.WriteLine("Mesa selecionada não existe.");
        }
    }

    private int EscolherOpcao(string mensagem, int maxOpcao)
    {
        int escolha;
        do
        {
            Console.Write(mensagem);
            escolha = int.Parse(Console.ReadLine());
        } while (!ValidarOpcao(escolha, maxOpcao));

        return escolha;
    }

    private bool ValidarOpcao(int escolha, int maxOpcao)
    {
        return escolha >= 1 && escolha <= maxOpcao;
    }
}