﻿using System.Text.Json.Serialization;

namespace ScrennSoundApi.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista : {Artista}");
        Console.WriteLine($"Musica : {Nome}");
        Console.WriteLine($"Duração : {Duracao /1000}");
        Console.WriteLine($"Gênero Musical : {Genero}");

    }
}
