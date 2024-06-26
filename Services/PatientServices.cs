using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Model;

namespace Pharmacy_Management_System_Version3.Services;

public class PatientServices
{
    private readonly ApplicationDataBaseContext _dbContext;

    public PatientServices(ApplicationDataBaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Patient>> Get()
    {
        return await _dbContext.Patients.ToListAsync();
    }

    public async Task Post(Patient patient)
    {
        await _dbContext.Patients.AddAsync(patient);
        await _dbContext.SaveChangesAsync();
    }
}