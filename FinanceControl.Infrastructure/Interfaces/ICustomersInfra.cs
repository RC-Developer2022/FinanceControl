using FinancaControl.Domain.Entities;

namespace FinanceControl.Infrastructure.Interfaces;

public interface ICustomersInfra
{
    Task<Customers?> GetAsyncById(int id);
    Task<Customers> GetAsyncByName(string name);
    Task<List<Customers>> GetAsyncById();
}
