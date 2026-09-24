using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class AirlineReviewAspect
{
    public int Id { get; set; }

    public int AirlineReviewId { get; set; }

    public byte ReviewAspectId { get; set; }

    public double Value { get; set; }

    public virtual AirlineReview AirlineReview { get; set; } = null!;

    public virtual ReviewAspect ReviewAspect { get; set; } = null!;
}
