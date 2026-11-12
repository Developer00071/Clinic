using Application.Interfaces;
using Application.Responses;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomsController(ILogger<RoomsController> logger , IRoomsService RoomService): ControllerBase
{
     private readonly ILogger<RoomsController> _logger;
    private IRoomsService service = RoomService;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddRoom(Rooms Room)
    {
       _logger.LogInformation($"{Room} added sucsesfuly at {DateTime.Now}");
        return await service.AddRoom(Room);
    }
    
    [HttpPut]
    public async Task<ApiResponse<bool>> UpdateRoom(Rooms Room)
    {
                _logger.LogInformation($"{Room} updated sucsesfuly at {DateTime.Now}");

        return await service.UpdateRoom(Room);
    }
    
    [HttpDelete]
    public async Task<ApiResponse<bool>> DeleteRoom(int id)
    {
                        _logger.LogInformation($"Room with id {id} deleted sucsesfuly at {DateTime.Now}");

        return await service.DeleteRoom(id);
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Rooms>> GetRoom(int id)
    {
                _logger.LogInformation($"get Room with id {id} at {DateTime.Now}");

        return await service.GetRoom(id);
    }
    
    [HttpGet]
    public async Task<ApiResponse<List<Rooms>>> GetRooms()
    {
                        _logger.LogInformation($"all Rooms was get at {DateTime.Now}");

        return await service.GetRooms();
    }
}
