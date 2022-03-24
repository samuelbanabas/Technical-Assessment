using Microsoft.EntityFrameworkCore;

namespace PhoneCode.Models
{
    public class CountryContext: DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options) 
        { 
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryDetail> countryDetails { get; set; }    


    }
}
