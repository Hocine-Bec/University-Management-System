namespace Domain.Entities
{
    /// <summary>
    /// Represents a country for nationality tracking
    /// </summary>
    public class Country
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }

}

