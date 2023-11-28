using FinancaControl.Domain.Entities;
using FinanceControl.Infrastructure.Interfaces;
using FinanceControl.Infrastructure.Interfaces.Base;
using FinanceControl.Infrastructure.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Services;

public sealed class CustomersInfra(FinanceDbContext context) : ICustomersInfra
{
    public async Task<Customers> GetAsyncById(int id)
    {
        return await context.Database.SqlQueryRaw<Customers>(
            "SELECT ClienteId, Nome, Telefone, DataVencimento, Indicacao, Observacao,Desconto " +
            "FROM Clientes " +
            $"WHERE ClienteId = {id} ").FirstOrDefaultAsync();
    }

    public async Task<Customers> GetAsyncByName(string name)
    {
        return await context.Database.SqlQueryRaw<Customers>(
            "SELECT ClienteId, Nome, Telefone, DataVencimento, Indicacao, Observacao,Desconto " +
            "FROM Clientes " +
            $"WHERE Nome = {name} ").FirstOrDefaultAsync();
    }

    public async Task<List<Customers>> GetAsyncById()
    {
        return await context.Database.SqlQueryRaw<Customers>(
            "SELECT ClienteId , Nome , Telefone , DataVencimento , Indicacao , Observacao , Desconto " +
            $"FROM Clientes ").ToListAsync(); 
    }
}
