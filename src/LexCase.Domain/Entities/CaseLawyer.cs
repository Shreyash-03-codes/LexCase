namespace LexCase.Domain.Entities;
public class CaseLawyer
{
    public Guid Id{get;set;}
    public Guid CaseId{get;set;}
    public Guid LawyerId{get;set;}
    public CaseLawyerRole Role{get;set;}
    public DateTime AssignedOn{get;set;}
    public Case? Case{get;set;}
    public Lawyer? Lawyer{get;set;}


}