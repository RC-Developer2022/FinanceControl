using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinancaControl.Domain.Entities;

public sealed class Customers
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string ExpiryDate { get; set; }
    public string? Recommendation { get; set; }
    public string? Observation { get; set;}
    public Decimal? Discount { get; set; }

    public Customers(){}

    public Customers(string name, string phone , string expiryDate)
    {
        Name = name;
        Phone = phone;
        ExpiryDate = expiryDate;
    }
}
