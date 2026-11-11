namespace Application.DTOs;

public class DoctorDto
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Specialty { get; set; }
    public bool IsActive { get; set; }
    public DateTime HiredAt { get; set; }
}
