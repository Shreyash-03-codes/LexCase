namespace LexCase.Domain.Entities;
public class Document
{
    public Guid Id{get;set;}
    public Guid CaseId{get;set;}
    public string FileName{get;set;}="";
    public string StoragePath{get;set;}="";
    public string ContentType{get;set;}="";
    public Guid UploadedByUserId{get;set;}
    public DateTime UploadedAt{get;set;}

    public Case? Case{get;set;}
    public User? UploadedByUser{get;set;}

    
    
}