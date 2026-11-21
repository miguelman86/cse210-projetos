using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco = new Endereco("avenida sao jose 209", "osasco", "sao paulo", "brasil");

        Cliente cliente = new Cliente("miguel", endereco);

        Pedido pedido = new Pedido(cliente);

        Produto produtoHarina = new Produto("harina", "JIUBBI", 6, 10);
        Produto produtoAcucar = new Produto("açucar", "JBUYKUYBK", 9, 5);

        pedido.AdicionarProduto(produtoHarina);
        pedido.AdicionarProduto(produtoAcucar);

        Console.WriteLine("Pedido 1: \n" + pedido.EtiquetaEmbalagem());
        Console.WriteLine(pedido.EtiquetaDeEnvio());
        Console.WriteLine("Total: " + pedido.TotalDoPedido() + "\n");

        Endereco endereco1 = new Endereco("211 S 4th St", "Oregon", "Illinois", "EUA");

        Cliente cliente1 = new Cliente("Sarah", endereco1);

        Pedido pedido1 = new Pedido(cliente1);

        Produto produtoArroz = new Produto("arroz", "KBHBLJB", 10, 5);
        Produto produtoFeijao = new Produto("feijao", "JHJBJHBLKJ", 10, 6);

        pedido1.AdicionarProduto(produtoArroz);
        pedido1.AdicionarProduto(produtoFeijao);

        Console.WriteLine("Pedido 2: \n" + pedido1.EtiquetaEmbalagem());
        Console.WriteLine(pedido1.EtiquetaDeEnvio());
        Console.WriteLine("Total: " + pedido1.TotalDoPedido() + "\n");

    }
}