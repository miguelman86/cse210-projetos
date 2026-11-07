using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Diario.");

        Diario diario1 = new Diario();
        GeradorDePerguntas geradorPerguntas = new GeradorDePerguntas();

        bool continuar = true;

        while (continuar)
        {

            Console.WriteLine("\nBem-vindo ao Programa de Diário!");
            Console.WriteLine("Por favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                string pergunta = geradorPerguntas.ObterPerguntaAleatoria();
                Console.WriteLine(pergunta);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                Console.Write("Como está seu humor hoje (ex: feliz, cansado)? ");
                string humor = Console.ReadLine();

                string data = DateTime.Now.ToShortDateString();
                Registro novoRegistro = new Registro(data, pergunta, resposta, humor);
                diario1.AdicionarRegistro(novoRegistro);
            }

            else if (escolha == "2")
            {
                diario1.ExibirTodos();
            }

            else if (escolha == "3")
            {
                Console.WriteLine("Qual é o nome do seu arquivo? ");
                string arquivo = Console.ReadLine();
                diario1.CarregarDoArquivo(arquivo);
            }

            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do seu arquivo? ");
                string arquivo = Console.ReadLine();
                diario1.SalvarNoArquivo(arquivo);
            }

            else if (escolha == "5")
            {
                continuar = false;
            }

            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

        }
    }
}