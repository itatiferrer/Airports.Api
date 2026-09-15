namespace Airports.Api.DTOs.DTOsSalida
{
    public class AirportListDto
    {
        public int Id { get; set; }

        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public CountryRefDto Country { get; set; } = new();

        public RegionRefDto Region { get; set; } = new();

        public bool ScheduledService { get; set; }

        public bool RunwayClosed { get; set; }
    }
}