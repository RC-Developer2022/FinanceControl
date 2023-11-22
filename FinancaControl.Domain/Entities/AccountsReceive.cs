using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinancaControl.Domain.Entities;

public sealed class AccountsReceive
{
    public int Id { get; private set; }
    public Decimal Value { get; private set; }

    public string ExpiryDate { get; private set; }

    public bool Received { get; private set; }

    public int CustomerId { get; private set; }

    public AccountsReceive() { }

    public AccountsReceive(decimal value , string expiryDate , int customerId)
    {
        Value = value;
        ExpiryDate = expiryDate;
        CustomerId = customerId;
    }
}
