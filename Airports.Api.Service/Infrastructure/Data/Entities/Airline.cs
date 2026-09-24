using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class Airline
{
    public int Id { get; set; }

    public string Iatacode { get; set; } = null!;

    public string? Icaocode { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AirlineCountry> AirlineCountries { get; set; } = new List<AirlineCountry>();

    public virtual ICollection<AirlineReview> AirlineReviews { get; set; } = new List<AirlineReview>();

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();

    public virtual ICollection<Route> Routes { get; set; } = new List<Route>();
}
