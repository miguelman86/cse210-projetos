using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();
        string nome = PerguntarNomeUsuario();
        int numeroFavorito = PerguntarNumeroFavorito();
        int numeroAlCuadrado = ElevarAoQuadrado(numeroFavorito);
        ExibirResultado(nome, numeroAlCuadrado);

        static void ExibirBoasVindas()
        {
            Console.WriteLine("Bem-Vindo ao Programa!");
        }

        static string PerguntarNomeUsuario()
        {
            Console.Write("Por favor, insira seu nome: ");
            string nome = Console.ReadLine();
            return nome;
        }

        static int PerguntarNumeroFavorito()
        {
            Console.Write("Por favor, insira seu número favorito: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        static int ElevarAoQuadrado(int numero)
        {
            int quadrado = numero * numero;
            return quadrado;
        }

        static void ExibirResultado(string nome, int numeroAlCuadrado)
        {
            Console.WriteLine($"Irmão {nome}, o quadrado do seu número é {numeroAlCuadrado}");
        }

    }

    
}