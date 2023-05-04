using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class DoctorWhoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 @"Server=DESKTOP-LQ3BMKQ;Database=DoctorWhoCore;Trusted_Connection=True;TrustServerCertificate=Yes"
            );
        }
    }
}