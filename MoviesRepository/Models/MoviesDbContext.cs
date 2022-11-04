using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MoviesRepository.Data.Models;
using System;

namespace MoviesRepository.Models
{
    public class MoviesDbContext:DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
           
            }
        public DbSet<Category> Category { get; set; }
        public DbSet<MoviesReportItem> MoviesReportItem { get; set; }
    }


    
}
