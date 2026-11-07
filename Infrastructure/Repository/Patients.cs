using Dapper;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class PatientsRepository(AppDbConection _AppDbConection) : IPatientsRepository
{
    private AppDbConection _AppDbConection = _AppDbConection;

   
    public async Task<bool> AddPatient(Patients Patients)
    {
        var connection = _AppDbConection.Connection();
        var query = "insert into Patientss(fullname, country, birthyear) values(@fullname, @country, @birthyear)";
        var res = await connection.ExecuteAsync(query, Patients);
        return res>0;
    }


    public async Task<bool> DeletePatient(int id)
    {
        var connection = _AppDbConection.Connection();
        var query = "delete from Patientss where id=@id";
        var res = await connection.ExecuteAsync(query, new{id});
        return res>0;
    }

    


    public async Task<Patients> GetPatient(int id)
    {
        var connection = _AppDbConection.Connection();
        var query = "select * from Patientss where id=@id";
        var res = await connection.QuerySingleOrDefaultAsync<Patients>(query, new{id});
        return res!;
    }

    


    public async Task<List<Patients>> GetPatients()
    {
        var connection = _AppDbConection.Connection();
        var query = "select * from Patientss";
        var res = await connection.QueryAsync<Patients>(query);
        return res.ToList();    
    }

   


    public async Task<bool> UpdatePatient(Patients Patients)
    {
        var connection = _AppDbConection.Connection();
        var query = "update Patientss set fullname=@fullname, country=@country, birthyear=@birthyear where id=@id";
        var res = await connection.ExecuteAsync(query, Patients);
        return res>0;
    }
}
