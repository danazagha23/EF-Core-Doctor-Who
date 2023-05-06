using DoctorWho.Db;
using DoctorWho.Db.Repositories;
using DoctorWho.Domain;
using Microsoft.EntityFrameworkCore;

DoctorWhoDbContext.context.Database.EnsureCreated();


//----- GetEnemyById -----

var enemy = EnemiesRepository.GetEnemyById(2);
Console.WriteLine(enemy.EnemyName, enemy.Description);

