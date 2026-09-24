using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Continent { get; set; }

    public string? Keywords { get; set; }

    public string? WikipediaLink { get; set; }

    public virtual ICollection<AirlineCountry> AirlineCountries { get; set; } = new List<AirlineCountry>();

    public virtual ICollection<Airport> Airports { get; set; } = new List<Airport>();

    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();
}
