using Application.Interfaces;
using Application.Responses;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController(IDoctorsService DoctorService): ControllerBase
{
    private IDoctorsService service = DoctorService;

    [HttpPost]
    public async Task<ApiResponse<bool>> AddDoctor(Doctors Doctor)
    {
        return await service.AddDoctor(Doctor);
    }
    
    [HttpPut]
    public async Task<ApiResponse<bool>> UpdateDoctor(Doctors Doctor)
    {
        return await service.UpdateDoctor(Doctor);
    }
    
    [HttpDelete]
    public async Task<ApiResponse<bool>> DeleteDoctor(int id)
    {
        return await service.DeleteDoctor(id);
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Doctors>> GetDoctor(int id)
    {
        return await service.GetDoctor(id);
    }
    [HttpPatch("{id:int}")]
    public async Task<ApiResponse<bool>> DeactivateDoctor(int id)
    {
        return await service.DeactivateDoctor(id);
    }
    
    [HttpGet]
    public async Task<ApiResponse<List<Doctors>>> GetDoctors()
    {
        return await service.GetDoctors();
    }
}
