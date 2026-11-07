using Application.Responses;
using Domain.Models;

namespace Application.Interfaces;

public interface IPatientsService
{
    Task<ApiResponse<bool>> AddPatient(Patients Patient);
    Task<ApiResponse<bool>> UpdatePatient(Patients Patient);
    Task<ApiResponse<bool>> DeletePatient(int id);
    Task<ApiResponse<Patients>> GetPatient(int id);
    Task<ApiResponse<List<Patients>>> GetPatients();
}
