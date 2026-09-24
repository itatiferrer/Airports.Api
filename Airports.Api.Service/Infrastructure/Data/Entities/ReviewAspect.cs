using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class ReviewAspect
{
    public byte Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<AirlineReviewAspect> AirlineReviewAspects { get; set; } = new List<AirlineReviewAspect>();
}
