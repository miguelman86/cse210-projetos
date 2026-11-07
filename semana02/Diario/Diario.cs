using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                arquivoSaida.WriteLine($"{registro._data} | {registro._textoPergunta} | {registro._textoResposta} | {registro._humor}");
            }
        }        
    }
    
    public void CarregarDoArquivo(string arquivo)
    {
        _registros.Clear();
        string[] linhas = File.ReadAllLines(arquivo);
        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');
            Registro registro = new Registro(partes[0].Trim(), partes[1].Trim(), partes[2].Trim(), partes[3].Trim());
            _registros.Add(registro);
        }     
    }

}