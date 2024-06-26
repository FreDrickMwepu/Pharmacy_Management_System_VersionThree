using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Model;

namespace Pharmacy_Management_System_Version3.Services;

public class ContractServices
{
    private readonly ApplicationDataBaseContext _dbContext;

    public ContractServices(ApplicationDataBaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Contract>> Get()
    {
        return await _dbContext.Contracts.ToListAsync();
    }

    public async Task Post(Contract contract)
    {
        await _dbContext.Contracts.AddAsync(contract);
        await _dbContext.SaveChangesAsync();
    }
}