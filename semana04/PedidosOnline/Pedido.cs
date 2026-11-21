public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;
    public Pedido(Cliente cliente)
    {
        _produtos = new List<Produto>();
        _cliente = cliente;        
    }

    public string EtiquetaEmbalagem()
    {
        string resultado = "";

        foreach (Produto produto in _produtos)
        {
            resultado += produto.GetNomeProduto() + " - " + produto.GetId() + "\n";
        }

        return resultado;
    }
    public string EtiquetaDeEnvio()
    {
        return "Cliente: " + _cliente.GetNome() + "\nEndereço: " + _cliente.GetEndereco().EnderecoCompleto();

    }
    public int TotalDoPedido()
    {
        int total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.PrecoPorQuantidade();
        }

        if (_cliente.MoraNosEUA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }
}
