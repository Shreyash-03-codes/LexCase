using Microsoft.EntityFrameworkCore;
using LexCase.Domain.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users{get; set;}
    public DbSet<Client> Clients{get; set;}
    public DbSet<Lawyer> Lawyers{get; set;}
    public DbSet<Case> Cases{get; set;}
    public DbSet<CaseLawyer> CaseLawyers{get; set;}
    public DbSet<CaseNote> CaseNotes{get; set;}
    public DbSet<Hearing> Hearings{get; set;}
    public DbSet<Document> Documents{get; set;}
    
}