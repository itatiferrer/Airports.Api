using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class Airport
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public int? RegionId { get; set; }

    public string AirportCode { get; set; } = null!;

    public byte Type { get; set; }

    public string? City { get; set; }

    public string? Municipality { get; set; }

    public string Name { get; set; } = null!;

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public short? ElevationFt { get; set; }

    public bool ScheduledService { get; set; }

    public string? GpsCode { get; set; }

    public string? Iatacode { get; set; }

    public string? LocalCode { get; set; }

    public string? HomeLink { get; set; }

    public string? WikipediaLink { get; set; }

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public double? FrequencyMhz { get; set; }

    public short? RunwayLengthFt { get; set; }

    public short? RunwayWidthFt { get; set; }

    public string? RunwaySurface { get; set; }

    public bool RunwayLighted { get; set; }

    public bool RunwayClosed { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Flight> FlightDestinationAirports { get; set; } = new List<Flight>();

    public virtual ICollection<Flight> FlightSourceAirports { get; set; } = new List<Flight>();

    public virtual Region? Region { get; set; }

    public virtual ICollection<Route> RouteDestAirports { get; set; } = new List<Route>();

    public virtual ICollection<Route> RouteSourceAirports { get; set; } = new List<Route>();
}
