using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinancaControl.Domain.Entities;

public sealed class Servers
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Site { get; set; }
    public string Contact { get; set; }
    public string? Observation { get; set; }

    public Servers(){}

    public Servers(string name, string site, string contact)
    {
        Name = name;
        Site = site;
        Contact = contact;
    }
}
