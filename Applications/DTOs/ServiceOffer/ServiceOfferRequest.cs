using Domain.Enums;

namespace Applications.DTOs.ServiceOffer;

public record struct ServiceOfferRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Fees { get; set; }
    public bool? IsActive { get; set; }
}