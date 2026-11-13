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

Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();

QuestBoard board = new QuestBoard(guild);
Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");
Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");

Console.WriteLine();
Console.WriteLine(floatQuest.GetInfo());
Console.WriteLine(sergey.GetInfo());









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
Loan loan = new Loan(1, 5.0);
Console.WriteLine($"Старт: {loan.TryStart(film1)}");
Console.WriteLine($"Повторный старт: {loan.TryStart(film1)}");
Console.WriteLine($"Возврат: {loan.TryFinish()}");
Console.WriteLine($"Рейтинг после возврата: {film1.Rating}");
Console.WriteLine($"Повторный возварт: {loan.TryFinish()}");
Console.WriteLine($"Рейтинг после повторного возврата: {film1.Rating}");
