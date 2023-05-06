using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;

using (DoctorWhoDbContext context = new DoctorWhoDbContext())
{
    context.Database.EnsureCreated();
}


FunctionsViewsAndStoredProcedures.Ex_Companions_Function(1);
FunctionsViewsAndStoredProcedures.Ex_Enemies_Function(2);
FunctionsViewsAndStoredProcedures.Ex_ViewEpisodes();
FunctionsViewsAndStoredProcedures.Ex_spSummariseEpisodes();
