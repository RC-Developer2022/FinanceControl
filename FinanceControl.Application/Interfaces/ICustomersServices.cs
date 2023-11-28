
using FinancaControl.Application.DTOs;

namespace FinanceControl.Application.Interfaces;

public interface ICustomersServices
{
    Task<CustomersDTO> GetAsyncById(int id);
    Task<CustomersDTO> GetAsyncByName(string name);
    Task<List<CustomersDTO>> GetAsyncCustomers();
    Task<CustomersDTO> AddPerson(CustomersDTO customersDto);
    Task<CustomersDTO> UpdatePerson(CustomersDTO customersDto);
    Task<bool> DeletePerson(int id);
}