using System;

public class Registro
{
    public string _data;
    public string _textoPergunta;
    public string _textoResposta;
    public string _humor;

    public Registro(string data, string textoPergunta, string textoResposta, string humor)
    {
        _data = data;
        _textoPergunta = textoPergunta;
        _textoResposta = textoResposta;
        _humor = humor;
    }

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}. Pergunta: {_textoPergunta}");
        Console.WriteLine($"Resporta: {_textoResposta}");
        Console.WriteLine($"{_humor}");
        Console.WriteLine();
    }
}