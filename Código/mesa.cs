public class Mesa
{
    private bool ocupada;
    private Cliente pessoa;

    public Mesa()
    {
        ocupada = false;
        pessoa = null;
    }

    public bool MesaOcupada()
    {
        return ocupada;
    }

  public void AdicionarPessoa(Cliente cliente, string entrada, string pratoPrincipal, string sobremesa, float precoTotal)
  {
      if (!ocupada)
      {
          pessoa = cliente;
          pessoa.Entrada = entrada;
          pessoa.PratoPrincipal = pratoPrincipal;
          pessoa.Sobremesa = sobremesa;
          pessoa.PrecoTotal = precoTotal;
          ocupada = true;
      }
  }


    public Cliente ObterPessoa()
    {
        return pessoa;
    }
}
