using System.Runtime.Versioning;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

    //konstruktor, bierze opcje które dostarczymy

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

            
        }
        public DbSet<AppUser> Users { get; set; }
    }

