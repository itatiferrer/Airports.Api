namespace Airports.Api.DTOs.Entrada
{
    public class CreateRegionDto
    {
        public int CountryId { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
    }
}