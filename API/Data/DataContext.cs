using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //Classe responsável por executar a persistência no BD
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users {get; set;}
    }
}