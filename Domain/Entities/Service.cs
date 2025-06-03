using Domain.Enums;

namespace Domain.Entities
{
    /// <summary>
    /// University service definition with fees for the 8 core services offered
    /// </summary>
    public class Service
    {
        public int Id { get; set; }
        public ServiceType ServiceType { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Fees { get; set; }
        public bool IsActive { get; set; } = true;
    }

}

