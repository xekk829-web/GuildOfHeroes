Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");

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
Console.WriteLine();

Console.WriteLine("=== АЛЬБОМ 2 ===");
Console.WriteLine($"Название: {shqcore.Name}");
Console.WriteLine($"Артист: {shqcore.Artist}");
Console.WriteLine($"Тип: {shqcore.Type}");
Console.WriteLine($"Год: {shqcore.Year}");
Console.WriteLine();

Console.WriteLine("=== АЛЬБОМ 3 ===");
Console.WriteLine($"Название: {militantum.Name}");
Console.WriteLine($"Артист: {militantum.Artist}");
Console.WriteLine($"Тип: {militantum.Type}");
Console.WriteLine($"Год: {militantum.Year}");
Console.WriteLine($"Оценка: {militantum.Rating}");
Console.WriteLine();