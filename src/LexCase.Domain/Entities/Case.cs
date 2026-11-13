using LexCase.Domain.Enums;

namespace LexCase.Domain.Entities;

public class Case
{
    public Guid Id { get; set; }
    public string CaseNumber { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public CaseStatus Status { get; set; } = CaseStatus.Open;
    public CasePriority Priority { get; set; } = CasePriority.Medium;
    public string CourtName { get; set; } = string.Empty;
    public DateTime OpenedOn { get; set; } = DateTime.UtcNow;
    public DateTime? ClosedOn { get; set; }

    public Guid ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public ICollection<CaseLawyer> CaseLawyers { get; } = [];
    public ICollection<Hearing> Hearings { get; } = [];
    public ICollection<Document> Documents { get; } = [];
    public ICollection<CaseNote> CaseNotes { get; } = [];
}