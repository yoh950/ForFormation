using ForFormation.Models;
using Microsoft.EntityFrameworkCore;

namespace ForFormation
{
    public class DefaultContext : DbContext
    {
        
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {

        }

        protected DefaultContext()
        {
        }

        public DbSet<Formation> Formations { get; set; }
        public DbSet<Avis> Avis { get; set; }

        public DbSet<Contact> Contact { get; set; }  
    }
}
