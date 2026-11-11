namespace LexCase.Domain.Entities;
public class CaseNote
{
    public Guid Id{get;set;}
    public Guid CaseId{get;set;}
    public string Content{get;set;}="";
    public Guid AuthorUserId{get;set;}
    public DateTime CreatedAt{get;set;}

    public Case? Case{get;set;}
    public User? AuthorUser{get;set;}
}