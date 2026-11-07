namespace Domain.Interfaces;

using Domain.Models;

public interface IRoomsRepository
{
    Task<bool> AddRoom(Rooms Rooms);
    Task<bool> UpdateRoom(Rooms Rooms);
    Task<bool> DeleteRoom(int id);
    Task<Rooms> GetRoom(int id);
    Task<List<Rooms>> GetRooms();
}
