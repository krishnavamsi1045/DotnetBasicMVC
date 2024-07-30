using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using solidReference.Models;
namespace solidReference.Data{
    public class dataBaseContext:DbContext
    {
        public dataBaseContext(DbContextOptions<dataBaseContext> options):base(options){

        }

        public DbSet<Country> _country { get;set;}
        public DbSet<City> _city { get;set;}

        public DbSet<student> _student { get;set;}
    }
}