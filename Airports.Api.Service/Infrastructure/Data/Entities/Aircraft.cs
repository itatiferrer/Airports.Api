using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class Aircraft
{
    public int Id { get; set; }

    public string? Iatacode { get; set; }

    public string? Name { get; set; }
}
