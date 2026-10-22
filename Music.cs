public class Music
{
    public string Name;
    public string Artist;
    public string Type;
    public int Year;
    public double Rating;

    public Music(string name, string artist, int year)
    {
        Name = name;
        Artist = artist;
        Type = "Album";
        Year = year;
        Rating = 0.0;
    }
}