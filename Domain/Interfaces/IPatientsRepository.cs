namespace Domain.Interfaces;
using Domain.Models;
public interface IPatientsRepository
{
     Task<bool> AddPatient(Patients Patients);
    Task<bool> UpdatePatient(Patients Patients);
    Task<bool> DeletePatient(int id);
    Task<Patients> GetPatient(int id);
    Task<List<Patients>> GetPatients();
}
