using Application.Interfaces;
using Application.Responses;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController(ILogger<DoctorsController> logger ,IDoctorsService DoctorService): ControllerBase
{
    private IDoctorsService service = DoctorService;

private readonly ILogger<DoctorsController> _logger;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddDoctor(Doctors Doctor)
    {
    _logger.LogInformation($"{Doctor} adde sucsesfuly at {DateTime.Now}");
        return await service.AddDoctor(Doctor);
        
    }
    
    [HttpPut]
    public async Task<ApiResponse<bool>> UpdateDoctor(Doctors Doctor)
    {
        _logger.LogInformation($"{Doctor} updated sucsesfuly at {DateTime.Now}");
        return await service.UpdateDoctor(Doctor);
    }
    
    [HttpDelete]
    public async Task<ApiResponse<bool>> DeleteDoctor(int id)
    {
        _logger.LogInformation($"Doctor with id {id} deleted sucsesfuly at {DateTime.Now}");
        return await service.DeleteDoctor(id);
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Doctors>> GetDoctor(int id)
    {
        _logger.LogInformation($"get dodoctor with id {id} at {DateTime.Now}");
        return await service.GetDoctor(id);
    }
    [HttpPatch("{id:int}")]
    public async Task<ApiResponse<bool>> DeactivateDoctor(int id)
    {
        _logger.LogInformation($"doctor with id {id} deactivated! at {DateTime.Now}");
        return await service.DeactivateDoctor(id);
    }
    
    [HttpGet]
    public async Task<ApiResponse<List<Doctors>>> GetDoctors()
    {
        _logger.LogInformation($"all doctors was get at {DateTime.Now}");
        return await service.GetDoctors();
    }
}

