using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class Flight
{
    public int Id { get; set; }

    public int AirlineId { get; set; }

    public int SourceAirportId { get; set; }

    public int DestinationAirportId { get; set; }

    public DateOnly FlightDate { get; set; }

    public short? DepTime { get; set; }

    public short? ArrTime { get; set; }

    public short? FlightNumber { get; set; }

    public string? TailNumber { get; set; }

    public short? ActualElapsedTime { get; set; }

    public short? AirTimeMin { get; set; }

    public short ArrDelayMin { get; set; }

    public short DepDelayMin { get; set; }

    public short Distance { get; set; }

    public bool Cancelled { get; set; }

    public bool Diverted { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual Airport DestinationAirport { get; set; } = null!;

    public virtual Airport SourceAirport { get; set; } = null!;
}
