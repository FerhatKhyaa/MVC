using AdonetCoreMVC1.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdonetCoreMVC1.Models
{
    public class MusteriVtContext : DbContext
    {
        public MusteriVtContext(DbContextOptions<MusteriVtContext> options) : base(options)
        {

        }

        public DbSet<Musteri> Musteris { get; set; }
    }
}
