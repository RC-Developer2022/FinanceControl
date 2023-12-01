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
    }

    public async Task<List<CustomersDTO>> GetAsyncCustomers()
    {
        try
        {
            var customer = await context.GetAsyncCustomers().ConfigureAwait(ConfigureAwaitOptions.ContinueOnCapturedContext);
            if (customer == null) throw new Exception("Esse cliente não existe");

            return mapper.Map<List<CustomersDTO>>(customer);
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    public async Task<CustomersDTO> AddCustomer(CustomersDTO customersDto)
    {
        try
        {
            var customer = mapper.Map<Customers>(customersDto);

            if (await context.GetAsyncById(customer.Id) == null)
            {
                generic.Add(customer);
                if (await generic.SaveChangesAsync())
                    return mapper.Map<CustomersDTO>(await context.GetAsyncById(customer.Id));
            }

            return null;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<CustomersDTO> UpdateCustomer(CustomersDTO customersDto)
    {
        try
        {
            var customer = mapper.Map<Customers>(customersDto);

            if (await context.GetAsyncById(customer.Id) == null)
            {
                generic.Update(customer);
                if (await generic.SaveChangesAsync())
                    return mapper.Map<CustomersDTO>(await context.GetAsyncById(customer.Id));
            }

            return null;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<bool> DeleteCustomer(int id)
    {
        try
        {
            var customers = await context.GetAsyncById(id);
            if (customers == null)
            {
                generic.Delete(customers);
                return await generic.SaveChangesAsync();   
            }
            return false;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}