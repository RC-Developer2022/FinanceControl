using AutoMapper;
using FinancaControl.Application.DTOs;
using FinancaControl.Domain.Entities;
using FinanceControl.Application.Interfaces;
using FinanceControl.Infrastructure.Interfaces;
using FinanceControl.Infrastructure.Interfaces.Base;
using FinanceControl.Application;

namespace FinanceControl.Application.Services;

public class CustomersServices(ICustomersInfra context, IGenericInfra generic) : ICustomersServices
{
    private Mapper mapper = new Mapper(new MapperConfiguration(cfg =>
        cfg.CreateMap<Customers, CustomersDTO>().ReverseMap()));
    public async Task<CustomersDTO> GetAsyncById(int id)
    {
        try
        {
            var customer = await context.GetAsyncById(id).ConfigureAwait(ConfigureAwaitOptions.ContinueOnCapturedContext);
            if (customer == null) throw new Exception("Esse cliente não existe");

            return mapper.Map<CustomersDTO>(customer);
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }

        return null;
    }

    public async Task<CustomersDTO> GetAsyncByName(string name)
    {
        try
        {
            var customer = await context.GetAsyncByName(name).ConfigureAwait(ConfigureAwaitOptions.ContinueOnCapturedContext);
            if (customer == null) throw new Exception("Esse cliente não existe");

            return mapper.Map<CustomersDTO>(customer);
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }

        return null;
    }

    public Task<List<CustomersDTO>> GetAsyncCustomers()
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