using FinancaControl.Application.DTOs;
using FinanceControl.Application.Interfaces;
using FinanceControl.Infrastructure.Interfaces;
using FinanceControl.Infrastructure.Interfaces.Base;

namespace FinanceControl.Application.Services;

public class CustomersServices(ICustomersInfra context, IGenericInfra generic) : ICustomersServices
{
    public Task<CustomersDTO?> GetAsyncById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CustomersDTO> GetAsyncById(string name)
    {
        throw new NotImplementedException();
    }

    public Task<List<CustomersDTO>> GetAsyncById()
    {
        throw new NotImplementedException();
    }

    public Task<CustomersDTO> AddPerson(CustomersDTO customersDto)
    {
        throw new NotImplementedException();
    }

    public Task<CustomersDTO> UpdatePerson(CustomersDTO customersDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePerson(int id)
    {
        throw new NotImplementedException();
    }
}