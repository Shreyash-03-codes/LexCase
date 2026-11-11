using System.Collections.ObjectModel;

namespace LexCase.Domain.Entities;
public class Case
{
    public Guid Id{get; set;}
    public string CaseNumber{get; set;}="";
    public string Title{get; set;}="";
    public string? Description{get; set;}="";
    public CaseStatus Status{get; set;}
    public CasePriority Priority{get;set;}
    public string CourtName{get; set;}="";
    public DateTime OpenedOn{get;set;}
    public DateTime? ClosedOn{get;set;}
    public Guid ClientId{get;set;}
    public Client? Client{get;set;}

    public ICollection<Lawyer> Lawyers{get;}=new Collection<Lawyer>();
    public ICollection<Hearing> Hearings{get;}=new Collection<Hearing>();
    public ICollection<Document> Documents{get;}=new Collection<Document>();
    public ICollection<CaseNote> CaseNotes{get;}=new Collection<CaseNote>();
    public ICollection<CaseLawyer> CaseLawyers{get;}=new Collection<CaseLawyer>();
 
}