using System;

class Program
{
    static void Main(string[] args)
    {

        string continuar = "sim";

        while (continuar == "sim")
        {
            Random geradorAleatorio = new Random();
            int numeroMagico = geradorAleatorio.Next(1, 100);

            int palpite = 0;
            int quantidadePalpites = 0;

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                string valorPalpite = Console.ReadLine();
                palpite = int.Parse(valorPalpite);

                quantidadePalpites = quantidadePalpites + 1;

                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }

                else if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }

                else
                {
                    Console.WriteLine($"Você adivinhou! Voce fez em {quantidadePalpites} palpites");
                }
            }

            Console.Write("Deseja continuar jogando (sim/nao)? ");
            continuar = Console.ReadLine();

        }

        Console.WriteLine("Obrigado por jogar");
    }
}