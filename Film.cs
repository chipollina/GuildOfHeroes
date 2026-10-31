public class Films {
    public string Name;
    public string Genre;
    public int Year;
    public double Rating { get; private set; }
    public Films(string name, double rating) {
        Name = name;
        Genre = "horror";
        Year = 2018;
        Rating = rating;
        if (Rating < 0) {
            Rating = 0;
        }

        if (Rating > 10) {
            Rating = 10;
        }
    
    }
    public void addreiting(double r) {
        if (r > 10 || r<0) {
            return;
        }
        Rating = r;
    }
}