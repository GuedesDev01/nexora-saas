using Nexora.Domain.Common;

namespace Nexora.Domain.Entities;

public class Company : BaseEntity
{
    public string Name { get; set; } = string.Empty;
}