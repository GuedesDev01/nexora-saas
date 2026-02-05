using Nexora.Domain.Entities;

namespace Nexora.Domain.Entities

{
    public string Email { get; set; } = string.Empty;
    public string Passwordhash { get; set; } = string.Empty;

    public Guid CompanyId { get; set; }
}
