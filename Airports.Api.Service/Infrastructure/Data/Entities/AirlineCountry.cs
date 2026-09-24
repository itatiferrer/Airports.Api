using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class AirlineCountry
{
    public int Id { get; set; }

    public int AirlineId { get; set; }

    public int CountryId { get; set; }

    public bool Native { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual Country Country { get; set; } = null!;
}
