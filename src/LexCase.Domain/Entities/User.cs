namespace LexCase.Domain.Entities;
public class User
{
    public Guid Id{get; set;}
    public DateTime CreatedAt=DateTime.UtcNow;

    public string Email{get; set;}="";
    public UserRole Role{get;set;}
    public string PasswordHash{get; set;}="";

    public bool IsActive{get; set;}

    public Lawyer? Lawyer{get;set;}
    public Client? Client{get;set;}
    
}