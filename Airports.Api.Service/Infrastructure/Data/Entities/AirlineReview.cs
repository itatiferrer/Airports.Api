using System;
using System.Collections.Generic;

namespace Airports.Api.Service.Infrastructure.Data.Entities;

public partial class AirlineReview
{
    public int Id { get; set; }

    public int AirlineId { get; set; }

    public int ReviewId { get; set; }

    public short OverallRating { get; set; }

    public string ReviewTitle { get; set; } = null!;

    public DateOnly ReviewDate { get; set; }

    public string Review { get; set; } = null!;

    public bool Verified { get; set; }

    public string? Aircraft { get; set; }

    public byte? TypeOfTraveller { get; set; }

    public byte? SeatType { get; set; }

    public string? Route { get; set; }

    public DateOnly? DateFlown { get; set; }

    public bool Recommended { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual ICollection<AirlineReviewAspect> AirlineReviewAspects { get; set; } = new List<AirlineReviewAspect>();
}
