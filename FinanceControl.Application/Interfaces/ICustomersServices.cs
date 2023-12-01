
using FinancaControl.Application.DTOs;

namespace FinanceControl.Application.Interfaces;

public interface ICustomersServices
{
    Task<CustomersDTO> GetAsyncById(int id);
    Task<CustomersDTO> GetAsyncByName(string name);
    Task<List<CustomersDTO>> GetAsyncCustomers();
    Task<CustomersDTO> AddCustomer(CustomersDTO customersDto);
    Task<CustomersDTO> UpdateCustomer(CustomersDTO customersDto);
    Task<bool> DeleteCustomer(int id);
}