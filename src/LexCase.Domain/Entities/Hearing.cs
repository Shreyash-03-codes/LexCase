namespace LexCase.Domain.Entities;
public class Hearing
{
    public Guid Id{get;set;}
    public Guid CaseId{get;set;}
    public DateTime ScheduledAt{get;set;}
    public string Location{get;set;}="";
    public string? Outcome{get;set;}="";
    public string? Notes{get;set;}="";
    public Case? Case{get;set;}
}