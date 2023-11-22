using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinancaControl.Domain.Entities;

public sealed class AccountsPay
{
    public int Id { get; private set; }
    public string Supplier { get; set; }

    public Decimal Value { get; private set; }

    public string ExpiryDate { get; private set; }

    public bool Pay { get; private set; }

    public AccountsPay() { }

    public AccountsPay(string supplier , decimal value , string expiryDate)
    {
        Supplier = supplier;
        Value = value;
        ExpiryDate = expiryDate;
    }
}
