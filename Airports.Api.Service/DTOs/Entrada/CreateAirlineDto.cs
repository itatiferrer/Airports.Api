
namespace Airports.Api.DTOs.Entrada
{
    public class CreateAirlineDto
    {
        public string IataCode { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int CountryId { get; set; }

        public List<int> CountryIds { get; set; } = new();
    }
}