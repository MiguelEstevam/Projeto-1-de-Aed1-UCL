using System;
using System.Collections.Generic;

public class Cardapio
{
    private List<ItemCardapio> entradas;
    private List<ItemCardapio> pratosPrincipais;
    private List<ItemCardapio> sobremesas;
  

    public Cardapio()
    {
        entradas = new List<ItemCardapio>
        {
            new ItemCardapio("Pão de queijo", 9.20f),
            new ItemCardapio("Sopa de abóbora", 15.40f)
        };

        pratosPrincipais = new List<ItemCardapio>
        {
            new ItemCardapio("Feijoada",  39.60f),
            new ItemCardapio("Frango com quiabo", 35.80f)
        };

        sobremesas = new List<ItemCardapio>
        {
            new ItemCardapio("Canjica", 20.00f),
            new ItemCardapio("Doce de leite", 15.10f)
        };

    }

    public void ExibirCardapio()
    {
        Console.WriteLine("=====================");
        Console.WriteLine("Cardápio:");
        Console.WriteLine("Entradas:");
        for (int i = 0; i < entradas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {entradas[i].Nome} - R${entradas[i].Preco:0.00}");
        }
        Console.WriteLine("Pratos Principais:");
        for (int i = 0; i < pratosPrincipais.Count; i++)
        {
            Console.WriteLine($"{i + 1 + entradas.Count}. {pratosPrincipais[i].Nome} - R${pratosPrincipais[i].Preco:0.00}");
        }
        Console.WriteLine("Sobremesas:");
        for (int i = 0; i < sobremesas.Count; i++)
        {
            Console.WriteLine($"{i + 1 + entradas.Count + pratosPrincipais.Count}. {sobremesas[i].Nome} - R${sobremesas[i].Preco:0.00}");
        }
        Console.WriteLine("=====================");
    }

  public float CalcularPrecoTotal(int entradaIndex, int pratoPrincipalIndex, int sobremesaIndex)
  {
      float total = 0.0f;
      if (entradaIndex == 1)
      {
          total += entradas[0].Preco;
      }
      if (entradaIndex == 2)
      {
          total += entradas[1].Preco;
      }

      if (pratoPrincipalIndex == 3 )
      {
          total += pratosPrincipais[0].Preco;
        
      }
      if (pratoPrincipalIndex == 4 )
      {
          total += pratosPrincipais[1].Preco;

      }

      if (sobremesaIndex == 5)
      {
          total += sobremesas[0].Preco;
      }
      if (sobremesaIndex == 6)
      {
          total += sobremesas[1].Preco;
      }

      return total;
  }




    public string GetItemNome(int itemIndex)
    {
        if (itemIndex >= 1 && itemIndex <= entradas.Count)
        {
            return entradas[itemIndex - 1].Nome;
        }
        else if (itemIndex > entradas.Count && itemIndex <= entradas.Count + pratosPrincipais.Count)
        {
            return pratosPrincipais[itemIndex - entradas.Count - 1].Nome;
        }
        else if (itemIndex > entradas.Count + pratosPrincipais.Count && itemIndex <= entradas.Count + pratosPrincipais.Count + sobremesas.Count)
        {
            return sobremesas[itemIndex - entradas.Count - pratosPrincipais.Count - 1].Nome;
        }

        return "Item não encontrado";
    }
}

public class ItemCardapio
{
    public string Nome;
    public float Preco;

    public ItemCardapio(string nome, float preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string GetNome(){
      return Nome;
    }
    public float GetPreco(){
      return Preco;
    }
  
}
