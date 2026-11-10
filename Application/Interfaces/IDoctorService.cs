using Application.Responses;
using Domain.Models;

namespace Application.Interfaces;

public interface IDoctorsService
{
    Task<ApiResponse<bool>> AddDoctor(Doctors Doctor);
    Task<ApiResponse<bool>> UpdateDoctor(Doctors Doctor);
    Task<ApiResponse<bool>> DeleteDoctor(int id);
    Task<ApiResponse<Doctors>> GetDoctor(int id);
    Task<ApiResponse<bool>> DeactivateDoctor(int id);
    Task<ApiResponse<List<Doctors>>> GetDoctors();
}
