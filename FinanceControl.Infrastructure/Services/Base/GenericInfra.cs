using FinanceControl.Infrastructure.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Services.Base;

public class GenericInfra(FinanceDbContext context) : IGenericInfra
{
    public void Add<T>(T entity) where T : class
    {
        context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
        context.Remove(entity);
    }

    public void DeleteRange<T>(T[] entityArray) where T : class
    {
        context.RemoveRange(entityArray);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await context.SaveChangesAsync()) > 0;
    }

    public void Update<T>(T entity) where T : class
    {
        context.Update(entity);
    }
}
