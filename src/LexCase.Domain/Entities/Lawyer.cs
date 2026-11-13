using System.Collections.ObjectModel;

namespace LexCase.Domain.Entities;
public class Lawyer
{
    public Guid Id{get;set;}
    public string Name{get;set;}="";
    public string Email{get;set;}="";
    public string BarNumber{get;set;}="";
    public string Specialization{get;set;}="";
    public Guid UserId{get;set;}

    public User? User{get;set;}

    public ICollection<CaseLawyer> CaseLawyers{get;}=[];

    
    
}