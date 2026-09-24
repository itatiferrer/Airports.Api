using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class Region
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public string Code { get; set; } = null!;

    public string LocalCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Keywords { get; set; }

    public string? WikipediaLink { get; set; }

    public virtual ICollection<Airport> Airports { get; set; } = new List<Airport>();

    public virtual Country Country { get; set; } = null!;
}
