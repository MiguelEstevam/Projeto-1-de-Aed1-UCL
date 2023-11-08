using System;

class Program
{
  static void Main(string[] args)
    {
        Restaurante restaurante = new Restaurante();

        while (true)
        {
            Console.WriteLine("Bem-vindo ao Fogão de Lenha. Escolha uma opção:");
            Console.WriteLine("1. Escolher sua refeição ");
            Console.WriteLine("2. Sair");
          

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    restaurante.ExecutarRestaurante();
                    break;
                case "2":
                    Console.WriteLine("Obrigado por nos escolher, volte sempre!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}
