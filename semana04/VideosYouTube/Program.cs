using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Comentario comentario1 = new Comentario("miguelman", "gostei");
        Comentario comentario2 = new Comentario("joao", "nao gostei");
        Comentario comentario3 = new Comentario("maria", "parece facil");
        Comentario comentario4 = new Comentario("jose", "parece dificil");

        Video video1 = new Video("Como fazer bolo", "Maria", 600);

        video1._comentarios.Add(comentario1);
        video1._comentarios.Add(comentario2);
        video1._comentarios.Add(comentario3);
        video1._comentarios.Add(comentario4);

        videos.Add(video1);

        Comentario comentario5 = new Comentario("laura", "obrigado pela informaçao");
        Comentario comentario6 = new Comentario("andrea", "foi facil de entender");
        Comentario comentario7 = new Comentario("rafael", "gostei do video");

        Video video2 = new Video("aprender C#", "Roberto", 500);

        video2._comentarios.Add(comentario5);
        video2._comentarios.Add(comentario6);
        video2._comentarios.Add(comentario7);

        videos.Add(video2);

        Comentario comentario8 = new Comentario("catherine", "adorei o video");
        Comentario comentario9 = new Comentario("andresa", "entendi todo");
        Comentario comentario10 = new Comentario("julio", "excellente");

        Video video3 = new Video("Aprender abstraçao", "Thiago", 900);

        video3._comentarios.Add(comentario8);
        video3._comentarios.Add(comentario9);
        video3._comentarios.Add(comentario10);

        videos.Add(video3);

        Comentario comentario11 = new Comentario("lorena", "tem mais videos?");
        Comentario comentario12 = new Comentario("regina", "muito bom");
        Comentario comentario13 = new Comentario("jasmin", "obrigado pelo video");

        Video video4 = new Video("aprender classes em c#", "Argenis", 800);

        video4._comentarios.Add(comentario11);
        video4._comentarios.Add(comentario12);
        video4._comentarios.Add(comentario13);

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitulo: {video._titulo}, Autor: {video._autor}, Tempo de duraçao: {video._duracao} segundos, Numero de comentarios: {video.NumeroDeComentarios()}");

            foreach (Comentario comentario in video._comentarios)
            {
                Console.WriteLine($"Usuario: {comentario._usuario}, Comentario: {comentario._texto}");
            }
        }

    }
}