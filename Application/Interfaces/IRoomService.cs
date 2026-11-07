using Application.Responses;
using Domain.Models;

namespace Application.Interfaces;

public interface IRoomsService
{
    Task<ApiResponse<bool>> AddRoom(Rooms Room);
    Task<ApiResponse<bool>> UpdateRoom(Rooms Room);
    Task<ApiResponse<bool>> DeleteRoom(int id);
    Task<ApiResponse<Rooms>> GetRoom(int id);
    Task<ApiResponse<List<Rooms>>> GetRooms();
}
