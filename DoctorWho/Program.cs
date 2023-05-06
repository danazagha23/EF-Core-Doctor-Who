using DoctorWho.Db;
using DoctorWho.Domain;
using Microsoft.EntityFrameworkCore;

DoctorWhoDbContext.context.Database.EnsureCreated();


//----- Execute the functions, sprocs and views ------

//FunctionsViewsAndStoredProcedures.Ex_Companions_Function(1);

//FunctionsViewsAndStoredProcedures.Ex_Enemies_Function(2);

//FunctionsViewsAndStoredProcedures.Ex_ViewEpisodes();

//FunctionsViewsAndStoredProcedures.Ex_spSummariseEpisodes();


//----- Create new Author -----

CreateUpdateDelete.CreateAuthor("New-Author");

//----- Update New-Author with id = 6 -----

var author = DoctorWhoDbContext.context.Authors.Find(6);

author.AuthorName = "New-Author (Updated !)";

Console.WriteLine(DoctorWhoDbContext.context.ChangeTracker.DebugView.LongView);

CreateUpdateDelete.UpdateAuthor();

Console.WriteLine(DoctorWhoDbContext.context.ChangeTracker.DebugView.LongView);

//----- Delete New-Author -----

CreateUpdateDelete.DeleteAuthor(author);

Console.WriteLine(DoctorWhoDbContext.context.ChangeTracker.DebugView.LongView);



