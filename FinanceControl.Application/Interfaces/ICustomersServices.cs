
using FinancaControl.Application.DTOs;

namespace FinanceControl.Application.Interfaces;

public interface ICustomersServices
{
    Task<CustomersDTO?> GetAsyncById(int id);
    Task<CustomersDTO> GetAsyncById(string name);
    Task<List<CustomersDTO>> GetAsyncById();
    Task<CustomersDTO> AddPerson(CustomersDTO customersDto);
    Task<CustomersDTO> UpdatePerson(CustomersDTO customersDto);
    Task<bool> DeletePerson(int id);
}