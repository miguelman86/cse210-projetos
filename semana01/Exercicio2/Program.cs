using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual o percentual da sua nota? ");
        string valorDigitado = Console.ReadLine();
        int percentual = int.Parse(valorDigitado);

        string letra = "";

        if (percentual >= 90)
        {
            letra = "A";
        }

        else if (percentual >= 80)
        {
            letra = "B";
        }

        else if (percentual >= 70)
        {
            letra = "C";
        }

        else if (percentual >= 60)
        {
            letra = "D";
        }

        else
        {
            letra = "F";
        }

        int ultimoDigito = percentual % 10;
        string sinal = "";

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }

        else if (ultimoDigito <= 3)
        {
            sinal = "-";
        }

        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }

        if (letra == "F")
        {
            sinal = "";
        }

        Console.WriteLine($"Sua nota é {letra}{sinal}");

        if (percentual >= 70)
        {
            Console.WriteLine("Parabens voce foi aprovado");
        }

        else
        {
            Console.WriteLine("Esforcece mais na proxima vez");
        }

    }
}