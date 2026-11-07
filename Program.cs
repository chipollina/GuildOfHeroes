//Probe.Run();
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);

guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);
List<Hero> members = guild.GetMembers();
Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");
if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}
Console.WriteLine();
foreach (Hero hero in members) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}

Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null) {
    Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
}
else {
    Console.WriteLine("По запросу « аРтЁм » никого нет.");
}
Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");








Console.WriteLine();
Catalog catalog = new Catalog("Ужасы 2018");

Films film1 = new Films("The Nun", 5.8);
Films film2 = new Films("reincarnation", 6.4);
Films film3 = new Films("Halloween", 5.8);
catalog.AddFilm(film1);
catalog.AddFilm(film2);
catalog.AddFilm(film3);
Console.WriteLine($">>> {catalog.Name}: всего фильмов {catalog.FilmCount} <<<");

List<Films> allFilms = catalog.GetFilms();
foreach (Films i in allFilms) {
    Console.WriteLine();
    Console.WriteLine($">>> {i.Name} <<<");
    Console.WriteLine($"Жанр: {i.Genre}");
    Console.WriteLine($"Год: {i.Year}");
    Console.WriteLine($"Рейтинг: {i.Rating}");
}
Console.WriteLine();
Console.WriteLine($"Повтор The Nun: {catalog.AddFilm(new Films("the nun", 7.0))}");

Films? foundFilm = catalog.FindFilm("  HALLOWEEN  ");
if (foundFilm != null) {
    Console.WriteLine($"Найден: {foundFilm.Name}");
} else {
    Console.WriteLine("Не найден.");
}
Films? missingFilm = catalog.FindFilm("Неизвестный");
Console.WriteLine($"Неизвестный не найден: {missingFilm == null}");

Console.WriteLine($"Удалён reincarnation: {catalog.RemoveFilm("REINCARNATION")}");
Console.WriteLine($"Осталось фильмов: {catalog.FilmCount}");
Console.WriteLine($"Хороших фильмов (7.0+): {catalog.CountGood()}");