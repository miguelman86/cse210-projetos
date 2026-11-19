using System;

class Program
{
    // Extra / Criatividade: Seleciona apenas palavras ainda visíveis para evitar ciclos redundantes

    static void Main(string[] args)
    {

        Referencia referencia = new Referencia("João", 3, 16);
        string textoExemplo = "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.";
        Escritura escritura = new Escritura(referencia, textoExemplo);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();

            if (escritura.EstaCompletamenteOculta())
            {
                break;
            }

            Console.Write("Pressione Enter para ocultar mais palavras ou digite 'sair': ");
            string entrada = Console.ReadLine() ?? string.Empty;

            if (entrada.Trim().ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }
    }
}