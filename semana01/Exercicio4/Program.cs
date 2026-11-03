using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;

        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        }

        int somaTotal = 0;

        foreach (int num in numeros)
        {
            somaTotal = somaTotal + num;
        }

        double media = (double) somaTotal /  numeros.Count;

        int maior = numeros[0];
        int menorPositivo = -1;

        foreach (int num in numeros)
        {
            if (num > maior)
            {
                maior = num;
            }
            if (num > 0)
            {
                if (menorPositivo == -1 || num < menorPositivo)
                {
                    menorPositivo = num;
                }
            }
        }

        Console.WriteLine($"A soma é: {somaTotal}");
        Console.WriteLine($"A média é: {media}");
        Console.WriteLine($"O maior número é: {maior}");

        if (menorPositivo > 0)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }

        Console.WriteLine("A lista reordenada é:");

        numeros.Sort();

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

    }
}