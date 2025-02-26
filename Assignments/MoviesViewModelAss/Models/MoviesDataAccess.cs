
namespace MoviesViewModelAss.Models
{
    public class MoviesDataAccess : IMoviesDataAccess
    {
        private readonly MoviesDBContext dbctx;
        public MoviesDataAccess(MoviesDBContext dbctx)
        {
            this.dbctx = dbctx;
        }
        public void AddMovie(Movies movies)
        {
            dbctx.movies.Add(movies);
            dbctx.SaveChanges();
        }

        public List<Movies> GetMovies()
        {
            return dbctx.movies.ToList();
        }
    }
}
