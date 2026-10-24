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


Films film1 = new Films("The Nun", 5.8);
Films film2 = new Films("reincarnation", 6.4);
Films film3 = new Films("Halloween", 5.8);

Console.WriteLine(">>> Фильм 1 <<<");
Console.WriteLine($"Название: {film1.Name}");
Console.WriteLine($"Жанр: {film1.Genre}");
Console.WriteLine($"Год: {film1.Year}");
Console.WriteLine($"Рейтинг: {film1.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Фильм 2 <<<");
Console.WriteLine($"Название: {film2.Name}");
Console.WriteLine($"Жанр: {film2.Genre}");
Console.WriteLine($"Год: {film2.Year}");
Console.WriteLine($"Рейтинг: {film2.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Фильм 3 <<<");
Console.WriteLine($"Название: {film3.Name}");
Console.WriteLine($"Жанр: {film3.Genre}");
Console.WriteLine($"Год: {film3.Year}");
Console.WriteLine($"Рейтинг: {film3.Rating}");