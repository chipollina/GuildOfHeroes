Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");












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

Console.WriteLine($"рейтинг до вызова:{film1.Rating}");
film1.addreiting(3);
Console.WriteLine($"рейтинг с допутимым вызовом {film1.Rating}");
film1.addreiting(-15);
Console.WriteLine($"рейтинг с не допутимым вызовом {film1.Rating}");


Console.WriteLine($"Рейтинг до вызова: {film1.Rating}");
film1.addreiting(7.5);
Console.WriteLine($"После допустимого вызова: {film1.Rating}");
film1.addreiting(-15);
Console.WriteLine($"После недопустимого вызова: {film1.Rating}");
