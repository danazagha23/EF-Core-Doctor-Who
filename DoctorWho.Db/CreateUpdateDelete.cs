using DoctorWho.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class CreateUpdateDelete
    {
        //Companions Methods
        public static void CreateCompanion(string companionName, string whoPlayed)
        {
            if (companionName == null || whoPlayed == null)
                throw new ArgumentNullException("Cannot create a Companion with a null CompanionName or a null WhoPlayed!");
            DoctorWhoDbContext.context.Companions.Add(new Companion { CompanionName = companionName, WhoPlayed = whoPlayed });
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void UpdateCompanion()
        {
            DoctorWhoDbContext.context.ChangeTracker.DetectChanges();
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void DeleteCompanion(Companion companion)
        {
            if(companion == null) throw new ArgumentNullException("Cannot remove a null Companion from the Companions table");
            DoctorWhoDbContext.context.Companions.Remove(companion);
            DoctorWhoDbContext.context.SaveChanges();
        }

        //Enemies Methods
        public static void CreateEnemy(string enemyName, string description)
        {
            if (enemyName == null) throw new ArgumentNullException("Cannot create an Enemy with a null EnemyName!");
            DoctorWhoDbContext.context.Enemies.Add(new Enemy { EnemyName = enemyName, Description = description });
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void UpdateEnemy()
        {
            DoctorWhoDbContext.context.ChangeTracker.DetectChanges();
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void DeleteEnemy(Enemy enemy)
        {
            if (enemy == null) throw new ArgumentNullException("Cannot remove a null Enemy from the Enemies table");
            DoctorWhoDbContext.context.Enemies.Remove(enemy);
            DoctorWhoDbContext.context.SaveChanges();
        }

        //Doctors Methods
        public static void CreateDoctor(int doctorNumber, string doctorName, DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate)
        {
            if (doctorName == null) throw new ArgumentNullException("Cannot create an Doctor with a null DoctorName!");
            DoctorWhoDbContext.context.Doctors.Add(new Doctor { DoctorNumber = doctorNumber ,DoctorName = doctorName, BirthDate = birthDate, FirstEpisodeDate = firstEpisodeDate, LastEpisodeDate = lastEpisodeDate });
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void UpdateDoctor()
        {
            DoctorWhoDbContext.context.ChangeTracker.DetectChanges();
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void DeleteDoctor(Doctor doctor)
        {
            if (doctor == null) throw new ArgumentNullException("Cannot remove a null Doctor from the Doctors table");
            DoctorWhoDbContext.context.Doctors.Remove(doctor);
            DoctorWhoDbContext.context.SaveChanges();
        }

        //Authors Methods
        public static void CreateAuthor(string authorName)
        {
            if (authorName == null) throw new ArgumentNullException("Cannot create an Author with a null AuthorName!");
            DoctorWhoDbContext.context.Authors.Add(new Author { AuthorName = authorName });
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void UpdateAuthor()
        {
            DoctorWhoDbContext.context.ChangeTracker.DetectChanges();
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void DeleteAuthor(Author author)
        {
            if (author == null) throw new ArgumentNullException("Cannot remove a null Author from the Authors table");
            DoctorWhoDbContext.context.Authors.Remove(author);
            DoctorWhoDbContext.context.SaveChanges();
        }

        //Episodes Methods
        public static void CreateEpisode(int? seriesNumber, int? episodeNumber, string episodeType, string title, DateTime? episodeDate, int authorId, int doctorId, string notes)
        {
            if (title == null) throw new ArgumentNullException("Cannot create an Episode with a null Title!");
            DoctorWhoDbContext.context.Episodes.Add(new Episode { SeriesNumber =  seriesNumber, EpisodeNumber = episodeNumber, EpisodeType = episodeType, Title = title, EpisodeDate = episodeDate, AuthorId = authorId, DoctorId = doctorId, Notes = notes});
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void UpdateEpisode()
        {
            DoctorWhoDbContext.context.ChangeTracker.DetectChanges();
            DoctorWhoDbContext.context.SaveChanges();
        }
        public static void DeleteEpisode(Episode episode)
        {
            if (episode == null) throw new ArgumentNullException("Cannot remove a null Episode from the Episodes table");
            DoctorWhoDbContext.context.Episodes.Remove(episode);
            DoctorWhoDbContext.context.SaveChanges();
        }
    }
}
