using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Model;

namespace Pharmacy_Management_System_Version3.Services;

public class DrugServices
{
    private readonly ApplicationDataBaseContext _dbContext;

    public DrugServices(ApplicationDataBaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Drug>> Get()
    {
        return await _dbContext.Drugs.ToListAsync();
    }

    public async Task Post(Drug drug)
    {
        await _dbContext.Drugs.AddAsync(drug);
        await _dbContext.SaveChangesAsync();
    }
}