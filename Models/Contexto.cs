using LHPet.Models;
using Microsoft.EntityFrameworkCore;

namespace Lhpet.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) : base(options)
        {
            
        }

        public DbSet<Cliente> Cliente {get; set;}
    }
}