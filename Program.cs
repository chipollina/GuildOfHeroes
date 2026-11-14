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
board.AddQuest(new Quest(101, "Вернуть поплавок", 100, 30));
board.TryAssign(101, "Сергей");
board.TryComplete(101);

board.AddQuest(new Quest(102, "Проверить нижнюю площадку", 100, 10));
board.AddQuest(new Quest(103, "Снять мерки для насоса больницы", 100, 20));
board.AddQuest(new Quest(104, "Обследовать ответвление", 100, 15));

Console.WriteLine($"Сергей на №102: {board.TryAssign(102, "Сергей")}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Отмена №102: {board.TryCancel(102)}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Завершение №103: {board.TryComplete(103)}");
Console.WriteLine($"Ярослав на №104: {board.TryAssign(104, "Ярослав")}");
Console.WriteLine($"Удалить Сергея: {board.TryRemoveMember("Сергей")}");

Console.WriteLine();
List<Quest> quests = board.GetQuests();
foreach (Quest quest in quests) {
    Console.WriteLine(quest.GetInfo());
}

Console.WriteLine();
Console.WriteLine(sergey.GetInfo());

Console.WriteLine($"Открыто: {board.CountByStatus(QuestStatus.Open)},назначено: {board.CountByStatus(QuestStatus.Assigned)}, выполнено: {board.CountByStatus(QuestStatus.Completed)}, отменено: {board.CountByStatus(QuestStatus.Cancelled)}");

Quest? yaroslavQuest = board.FindActiveQuest("Ярослав");
if (yaroslavQuest != null) {
    Console.WriteLine($"Ярослав сейчас: №{yaroslavQuest.Id} «{yaroslavQuest.Title}»");
}

Quest? sergeyQuest = board.FindActiveQuest("Сергей");
if (sergeyQuest == null) {
    Console.WriteLine("Сергей сейчас: свободен");
}









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
Loan loan1 = new Loan(1, 5.0);
Loan loan2 = new Loan(2, 5.0);
catalog.AddLoan(loan1);
catalog.AddLoan(loan2);

Console.WriteLine($"Старт loan1: {catalog.TryStartLoan(1, film1)}");
Console.WriteLine($"Старт loan2: {catalog.TryStartLoan(2, film1)}");
Console.WriteLine($"Отмена loan1: {loan1.TryCancel()}");
Console.WriteLine($"Старт loan2: {catalog.TryStartLoan(2, film1)}");
Console.WriteLine($"Возврат loan2: {loan2.TryFinish()}");
Console.WriteLine($"Рейтинг film1: {film1.Rating}");
