using System.Collections.ObjectModel;
using LexCase.Domain.Enums;


namespace LexCase.Domain.Entities;
public class Client
{
    public Guid Id{get; set;}
    public string Name{get; set;}="";
    public string Email{get; set;}="";
    public string? Phone{get; set;}="";
    public ClientType Type{get;set;}
    public Guid? UserId{get; set;}

    public User? User{get; set;}

    public ICollection<Case> Cases{get;}=[];

}