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

hm.Type = "EP";

Console.WriteLine("=== АЛЬБОМ 1 ===");
Console.WriteLine($"Название: {hm.Name}");
Console.WriteLine($"Артист: {hm.Artist}");
Console.WriteLine($"Тип: {hm.Type}");
Console.WriteLine($"Год: {hm.Year}");
Console.WriteLine($"Оценка: {hm.Rating}");
Console.WriteLine($"Количество оценок: {hm.NumberOfRatings}");
Console.WriteLine();

Console.WriteLine("=== АЛЬБОМ 2 ===");
Console.WriteLine($"Название: {shqcore.Name}");
Console.WriteLine($"Артист: {shqcore.Artist}");
Console.WriteLine($"Тип: {shqcore.Type}");
Console.WriteLine($"Год: {shqcore.Year}");
Console.WriteLine($"Оценка: {shqcore.Rating}");
Console.WriteLine($"Количество оценок: {shqcore.NumberOfRatings}");
Console.WriteLine();

Console.WriteLine("=== АЛЬБОМ 3 ===");
Console.WriteLine($"Название: {militantum.Name}");
Console.WriteLine($"Артист: {militantum.Artist}");
Console.WriteLine($"Тип: {militantum.Type}");
Console.WriteLine($"Год: {militantum.Year}");
Console.WriteLine($"Оценка: {militantum.Rating}");
Console.WriteLine($"Количество оценок: {militantum.NumberOfRatings}");
Console.WriteLine();

Console.WriteLine($"Оценка альбома \"{shqcore.Name}\" до вызова: {shqcore.Rating} с {shqcore.NumberOfRatings} оценок пользователей");

shqcore.AddRating(5);
shqcore.AddRating(4);
shqcore.AddRating(5);

Console.WriteLine($"Оценка альбома \"{shqcore.Name}\" после трёх правильных вызовов: {shqcore.Rating} с {shqcore.NumberOfRatings} оценок пользователей");

shqcore.AddRating(6);
shqcore.AddRating(-2);


Console.WriteLine($"Оценка альбома \"{shqcore.Name}\" после двух неправильных вызовов (не изменился): {shqcore.Rating} с {shqcore.NumberOfRatings} оценок пользователей");