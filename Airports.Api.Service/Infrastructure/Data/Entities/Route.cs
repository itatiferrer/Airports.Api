using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class Route
{
    public int Id { get; set; }

    public int AirlineId { get; set; }

    public int SourceAirportId { get; set; }

    public int DestAirportId { get; set; }

    public string? CodeShare { get; set; }

    public byte? Stops { get; set; }

    public string? Equipment { get; set; }

    public short? DistanceKm { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual Airport DestAirport { get; set; } = null!;

    public virtual Airport SourceAirport { get; set; } = null!;
}
