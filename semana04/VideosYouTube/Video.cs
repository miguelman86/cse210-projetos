public class Video
{
    public string _titulo;
    public string _autor;
    public int _duracao;
    public List<Comentario> _comentarios;
    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }
    public int NumeroDeComentarios()
    {
        return _comentarios.Count;
    }
}