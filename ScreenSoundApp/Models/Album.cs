namespace ScreenSound.Models;

internal class Album
{
    public Album(string albumName)
    {
        AlbumName = albumName;
    }

    public List<Music> musics = new List<Music>();
    public string? AlbumName { get; }
    public int DuracaoTotal => musics.Sum(music => music.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumMusics()
    {
        foreach (Music music in musics)
        {
            Console.WriteLine($"Music: {music.MusicName}, Duration: {music.Duration} seconds");
        }
        Console.WriteLine($"\nThe {AlbumName} Album has a total duration of {DuracaoTotal} seconds");
    }
}