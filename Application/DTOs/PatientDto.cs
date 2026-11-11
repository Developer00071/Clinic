namespace Application.DTOs;

public class PatientDto
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Phone { get; set; }
    public DateOnly BirthDate { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}
