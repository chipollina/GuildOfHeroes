public class Loan {
    public int Id { get; private set; }
    public double MinRating { get; private set; }
    public Films? AssignedFilm { get; private set; }
    public LoanStatus Status { get; private set; }

    public Loan(int id, double minRating) {
        Id = id;
        MinRating = minRating;
        AssignedFilm = null;
        Status = LoanStatus.Open;
    }

    public bool TryStart(Films film) {
        if (Status != LoanStatus.Open) {
            return false;
        }
        if (AssignedFilm != null) {
            return false;
        }
        if (film.Rating < MinRating) {
            return false;
        }

        AssignedFilm = film;
        Status = LoanStatus.Active;
    return true;
    }

    public bool TryFinish() {
        if (Status != LoanStatus.Active) {
            return false;
        }

        Films? film = AssignedFilm;
        if (film == null) {
            return false;
        }

        film.addreiting(film.Rating + 0.5);
        Status = LoanStatus.Returned;
        return true;
    }

    public bool TryCancel() {
        if (Status != LoanStatus.Open && Status != LoanStatus.Active) {
            return false;
        }

        Status = LoanStatus.Cancelled;
        return true;
    }
}