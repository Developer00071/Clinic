using Application.Interfaces;
using Application.Responses;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController(IPatientsService PatientService): ControllerBase
{
    private IPatientsService service = PatientService;

    [HttpPost]
    public async Task<ApiResponse<bool>> AddPatient(Patients Patient)
    {
        return await service.AddPatient(Patient);
    }
    
    [HttpPut]
    public async Task<ApiResponse<bool>> UpdatePatient(Patients Patient)
    {
        return await service.UpdatePatient(Patient);
    }
    
    [HttpDelete]
    public async Task<ApiResponse<bool>> DeletePatient(int id)
    {
        return await service.DeletePatient(id);
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Patients>> GetPatient(int id)
    {
        return await service.GetPatient(id);
    }
    
    [HttpGet]
    public async Task<ApiResponse<List<Patients>>> GetPatients()
    {
        return await service.GetPatients();
    }
}
