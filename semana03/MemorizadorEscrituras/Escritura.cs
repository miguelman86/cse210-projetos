public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    private Random _aleatorio;
    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();
        _aleatorio = new Random();

        string[] partes = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string parte in partes)
        {
            _palavras.Add(new Palavra(parte));
        }
    }
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        List<Palavra> palavrasVisisveis = new List<Palavra>();

        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                palavrasVisisveis.Add(palavra);
            }
        }

        int limite = Math.Min(numeroParaOcultar, palavrasVisisveis.Count);

        for (int i = 0; i < limite; i++)
        {
            int indice = _aleatorio.Next(palavrasVisisveis.Count);
            palavrasVisisveis[indice].Ocultar();
            palavrasVisisveis.RemoveAt(indice);
        }
    }
    public string ObterTexto()
    {
        List<string> palavrasFormatadas = new List<string>();
        foreach (Palavra palavra in _palavras)
        {
            palavrasFormatadas.Add(palavra.ObterTexto());
        }
        return $"{_referencia.ObterTexto()} - {string.Join(" ", palavrasFormatadas)}";

    }
    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }
        return true;
    }


}