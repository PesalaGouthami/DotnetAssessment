namespace MoviesViewModelAss.Models
{
    public interface IMoviesDataAccess
    {
        void AddMovie(Movies movies);
        List<Movies> GetMovies();
    }
}
