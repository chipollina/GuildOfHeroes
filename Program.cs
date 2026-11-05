//Probe.Run();
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);

guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);
Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");
if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}
Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

int strongCount = 0;
foreach (Hero i in guild.Heroes) {
    if (i.Health >= 120) {
        strongCount++;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[0];
    foreach (Hero i in guild.Heroes) {
        if (i.Health > strongest.Health) {
            strongest = i;
        }
    }
    Console.WriteLine($"Самый здоровый:{strongest.Name} ({strongest.Health})");
}






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

List<Films> films = new List<Films>();
films.Add(film1);
films.Add(film2);
films.Add(film3);
if (films.Count > 0) {
    Console.WriteLine($"Первый: {films[0].Name}");
    Console.WriteLine($"Последний: {films[films.Count - 1].Name}");
}
foreach (Films film in films) {
    Console.WriteLine($"{film.Name}: рейтинг {film.Rating}");
}
Films film4 = new Films("Новый фильм", 7.0);
films.Add(film4);
int goodCount = 0;
foreach (Films i in films) {
    if (i.Rating >= 7.0) {
        goodCount++;
    }
}
Console.WriteLine($"Фильмов с рейтиногом больше 7.0: {goodCount}");
film1.addreiting(9.0);
Console.WriteLine($"film1 через список: {films[0].Rating}");