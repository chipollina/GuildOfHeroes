public class Loan {
    public int Id { get; private set; }
    public double MinRating { get; private set; }
    public Films? AssignedFilm { get; private set; }
    public bool IsFinished { get; private set; }

    public Loan(int id, double minRating) {
        Id = id;
        MinRating = minRating;
        AssignedFilm = null;
        IsFinished = false;
    }

    public bool TryStart(Films film) {
        if (IsFinished) {
            return false;
        }
        if (AssignedFilm != null) {
            return false;
        }
        if (film.Rating < MinRating) {
            return false;
        }

        AssignedFilm = film;
        return true;
    }

    public bool TryFinish() {
        if (IsFinished) {
            return false;
        }

        Films? film = AssignedFilm;
        if (film == null) {
            return false;
        }

        film.addreiting(film.Rating + 0.5);
        IsFinished = true;
        return true;
    }
}