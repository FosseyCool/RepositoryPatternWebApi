using MyMDB.Models;
using RepositoryPatternWebApi.Models;

namespace RepositoryPatternWebApi.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyMDBContext>
    {
        public EfCoreMovieRepository(MyMDBContext context) : base(context)
        {
        }
    }
}