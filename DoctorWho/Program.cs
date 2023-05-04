using DoctorWho.Db;

using(DoctorWhoDbContext context = new DoctorWhoDbContext())
{
    context.Database.EnsureCreated();
}