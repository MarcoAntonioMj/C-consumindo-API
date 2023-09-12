﻿using ScrennSoundApi.Modelos;

namespace ScrennSoundApi.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero} ");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
    foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtistas)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtistas)).ToList();
        Console.WriteLine(nomeDoArtistas);
        foreach (var musica in musicasDoArtista) 
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.Nome) // ordena as músicas pelo nome
    .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
            .Distinct() // remove as duplicidades
            .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas de {ano}");
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    internal static void FltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#"))
        .Select(musica => musica.Nome)
        .ToList();
        Console.WriteLine("Musicas em c#");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
