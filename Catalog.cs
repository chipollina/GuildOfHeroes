public class Catalog {
    private List<Films> _films = new List<Films>();

    public string Name { get; private set; }

    public int FilmCount {
        get { return _films.Count; }
    }

    public Catalog(string name) {
        Name = name;
    }

    public bool AddFilm(Films film) {
        if (FindFilm(film.Name) != null) {
            return false;
        }

        _films.Add(film);
        return true;
    }

    public Films? FindFilm(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        string key = name.Trim();

        foreach (Films film in _films) {
            if (string.Equals(film.Name, key, StringComparison.OrdinalIgnoreCase)) {
                return film;
            }
        }

        return null;
    }

    public bool RemoveFilm(string name) {
        Films? film = FindFilm(name);
        if (film == null) {
            return false;
        }
        return _films.Remove(film);
    }

    public List<Films> GetFilms() {
        List<Films> copy = new List<Films>();
        foreach (Films film in _films) {
            copy.Add(film);
        }
        return copy;
    }

    public int CountGood() {
        int count = 0;
        foreach (Films film in _films) {
            if (film.Rating >= 7.0) {
                count += 1;
            }
        }
        return count;
    }
}