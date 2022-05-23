using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMDB.Models;
using RepositoryPatternWebApi.Data.EFCore;
using RepositoryPatternWebApi.Models;

namespace RepositoryPatternWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMdbController<Movie,EfCoreMovieRepository>
    {

        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
        
    }
}
