using DoctorWho.Domain;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class DoctorWhoDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 @"Server=DESKTOP-LQ3BMKQ;Database=DoctorWhoCore;Trusted_Connection=True;TrustServerCertificate=Yes"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Author Constraints
            modelBuilder.Entity<Author>().HasKey(a => a.AuthorId);
            modelBuilder.Entity<Author>().Property(a => a.AuthorName).IsRequired();

            //Companion Constraints
            modelBuilder.Entity<Companion>().HasKey(c => c.CompanionId);
            modelBuilder.Entity<Companion>().Property(c => c.CompanionName).IsRequired();
            modelBuilder.Entity<Companion>().Property(c => c.WhoPlayed).IsRequired();

            //Doctor Constraints
            modelBuilder.Entity<Doctor>().HasKey(d => d.DoctorId);
            modelBuilder.Entity<Doctor>().Property(d => d.DoctorId).IsRequired();
            modelBuilder.Entity<Doctor>().Property(d => d.DoctorName).IsRequired();
            modelBuilder.Entity<Doctor>().Property(d => d.BirthDate).HasDefaultValueSql("NULL");
            modelBuilder.Entity<Doctor>().Property(d => d.FirstEpisodeDate).HasDefaultValueSql("NULL");
            modelBuilder.Entity<Doctor>().Property(d => d.LastEpisodeDate).HasDefaultValueSql("NULL");
            
            //Enemy Constraints
            modelBuilder.Entity<Enemy>().HasKey(e => e.EnemyId);
            modelBuilder.Entity<Enemy>().Property(e => e.EnemyName).IsRequired();
            modelBuilder.Entity<Enemy>().Property(e => e.Description).HasDefaultValueSql("NULL");
            
            //Episode Constraints
            modelBuilder.Entity<Episode>().HasKey(e => e.EpisodeId);
            modelBuilder.Entity<Episode>().Property(e => e.SeriesNumber).HasDefaultValueSql("0");
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeNumber).HasDefaultValueSql("0");
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeType).IsRequired();
            modelBuilder.Entity<Episode>().Property(e => e.Title).IsRequired();
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeDate).HasDefaultValueSql("NULL");
            modelBuilder.Entity<Episode>().Property(e => e.Notes).HasDefaultValueSql("NULL");
            
            //EpisodeCompanion Constraints
            modelBuilder.Entity<EpisodeCompanion>().HasKey(ec => ec.CompanionId);
            modelBuilder.Entity<EpisodeCompanion>()
                .HasOne(ec => ec.Companion)
                .WithMany(e => e.EpisodeCompanions)
                .HasForeignKey(ec => ec.CompanionId);
            modelBuilder.Entity<EpisodeCompanion>()
                .HasOne(ec => ec.Episode)
                .WithMany(e => e.EpisodeCompanions)
                .HasForeignKey(ec => ec.EpisodeId);
            
            //EpisodeEnemy Constraints
            modelBuilder.Entity<EpisodeEnemy>().HasKey(ee => ee.EpisodeEnemyId);
            modelBuilder.Entity<EpisodeEnemy>()
                .HasOne(ee => ee.Enemy)
                .WithMany(e => e.EpisodeEnemies)
                .HasForeignKey(ee => ee.EnemyId);
            modelBuilder.Entity<EpisodeEnemy>()
                .HasOne(ee => ee.Episode)
                .WithMany(e => e.EpisodeEnemies)
                .HasForeignKey(ee => ee.EpisodeId);
        }
    }
}