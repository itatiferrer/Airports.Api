namespace Airports.Api.DTOs.Entrada
{
    public class CreateCountryDto
    {
        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public List<CreateInitialRegionDto> Regions { get; set; } = new();
    }
}