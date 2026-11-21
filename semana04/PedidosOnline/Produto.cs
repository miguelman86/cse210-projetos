public class Produto
{
    private string _nomeProduto;
    private string _id;
    private int _precoPorUnidade;
    private int _quantidade;
    public Produto(string nome, string id, int preco, int quantidade)
    {
        _nomeProduto = nome;
        _id = id;
        _precoPorUnidade = preco;
        _quantidade = quantidade;
    }
    public int PrecoPorQuantidade()
    {
        int total = _precoPorUnidade * _quantidade;
        return total;
    }
    public string GetNomeProduto()
    {
        return _nomeProduto;
    }
    public string GetId()
    {
        return _id;
    }
    

}