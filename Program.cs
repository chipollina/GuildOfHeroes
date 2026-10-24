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