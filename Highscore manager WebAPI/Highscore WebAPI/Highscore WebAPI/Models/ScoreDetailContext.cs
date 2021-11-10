using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Highscore_WebAPI.Models
{
    public class ScoreDetailContext : DbContext
    {
        public ScoreDetailContext(DbContextOptions<ScoreDetailContext> options):base(options)
        {
              
        }

        public DbSet<ScoreDetail> ScoreDetails { get; set; }
    }
}
