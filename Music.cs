public class Music {
    public string Name;
    public string Artist;
    public string Type;
    public int Year;
    public double Rating;
    public int NumberOfRatings;

    public Music(string name, string artist, int year) {
        Name = name;
        Artist = artist;
        Type = "Album";
        Year = year;
        Rating = 0.0;
        NumberOfRatings = 0;
    }

    public void AddRating(int rate) {
        if (rate <= 0 || rate > 5) {
            return;
        }

        if (Rating == 0.0) {
            Rating = Convert.ToDouble(rate);
        }
        else {
            Rating = Math.Round((Rating * NumberOfRatings + Convert.ToDouble(rate)) / (NumberOfRatings + 1), 2);
        }
        NumberOfRatings += 1;
    }

    public bool IsRecommended(double minRate) {
        if (Rating >= minRate) {
            return true;
        }
        else {
            return false;
        }
    }

    public string GetInfo() {
        return $">>> {Name} <<<\n" +
               $"Артист: {Artist}\n" +
               $"Тип: {Type}\n" +
               $"Год: {Year}\n" +
               $"Оценка: {Rating}\n" +
               $"Количество оценок: {NumberOfRatings}";
    }
}