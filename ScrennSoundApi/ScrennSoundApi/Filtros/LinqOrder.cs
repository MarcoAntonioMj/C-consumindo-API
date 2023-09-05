using ScrennSoundApi.Modelos;

namespace ScrennSoundApi.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
