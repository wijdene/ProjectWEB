using Microsoft.EntityFrameworkCore;
using MoviesRepository.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRepository.Data.Helpers
{
    public class HelperContext : DbContext
    {
       
        public HelperContext(DbContextOptions<HelperContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<MoviesReportItem> MoviesReportItem { get; set; }
    }
}
