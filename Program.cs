Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
}
else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());

Console.WriteLine();
Console.WriteLine("--------------------------------");
Console.WriteLine("САМОСТОЯТЕЛЬНЫЕ ЗАДАНИЯ");
Console.WriteLine("--------------------------------");
Console.WriteLine();

Music hm = new Music("Heavy Metal", "Kai Angel & 9mice", 2023);
Music shqcore = new Music("Shqcore", "Sqwore", 2025);
Music militantum = new Music("MILITANTUM", "тёмный принц", 2026);

List<Music> collection = [hm, shqcore, militantum];
int counter = 1;

foreach (Music album in collection) {
    Console.WriteLine($"=== АЛЬБОМ {counter} ===");
    Console.WriteLine(album.GetInfo());
    Console.WriteLine();
    counter++;
}

collection[0].Type = "EP";

Console.WriteLine($"Оценка альбома \"{collection[1].Name}\" до вызова: {collection[1].Rating} с {collection[1].NumberOfRatings} оценок пользователей");

collection[1].AddRating(5);
collection[1].AddRating(4);
collection[1].AddRating(5);

Console.WriteLine($"Оценка альбома \"{collection[1].Name}\" после трёх правильных вызовов: {collection[1].Rating} с {collection[1].NumberOfRatings} оценок пользователей");

collection[1].AddRating(6);
collection[1].AddRating(-2);

Console.WriteLine($"Оценка альбома \"{collection[1].Name}\" после двух неправильных вызовов (не изменился): {collection[1].Rating} с {collection[1].NumberOfRatings} оценок пользователей");

collection[0].AddRating(3);
collection[0].AddRating(4);
collection[0].AddRating(3);

collection[2].AddRating(5);
collection[2].AddRating(4);
collection[2].AddRating(4);

foreach (Music album in collection) {
    if (album.IsRecommended(4.0)) {
        Console.WriteLine($"Альбом \"{album.Name}\" от {album.Artist} можно слушать");
    }
    else {
        Console.WriteLine($"Альбом \"{album.Name}\" от {album.Artist} нельзя слушать");
    }
}