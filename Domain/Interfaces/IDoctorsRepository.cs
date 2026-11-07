using Domain.Models;

namespace Domain.Interfaces;

public interface IDoctorsRepository
{
     Task<bool> AddDoctor(Doctors doctors);
    Task<bool> UpdateDoctor(Doctors doctors);
    Task<bool> DeleteDoctor(int id);
    Task<Doctors> GetDoctor(int id);
    Task<List<Doctors>> GetDoctors();
}
