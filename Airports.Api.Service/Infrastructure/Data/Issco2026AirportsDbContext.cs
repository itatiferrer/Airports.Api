using System;
using System.Collections.Generic;
using Airports.Api.Service.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using RouteEntity = Airports.Api.Service.Infrastructure.Data.Entities.Route;

namespace Airports.Api.Service.Infrastructure.Data;

public partial class Issco2026AirportsDbContext : DbContext
{
    public Issco2026AirportsDbContext(DbContextOptions<Issco2026AirportsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aircraft> Aircrafts { get; set; }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<AirlineCountry> AirlineCountries { get; set; }

    public virtual DbSet<AirlineReview> AirlineReviews { get; set; }

    public virtual DbSet<AirlineReviewAspect> AirlineReviewAspects { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<ReviewAspect> ReviewAspects { get; set; }

    public virtual DbSet<RouteEntity> Routes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Aircraft>(entity =>
        {
            entity.HasIndex(e => e.Iatacode, "IX_Aircrafts_IATACode").IsUnique();

            entity.Property(e => e.Iatacode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("IATACode");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasIndex(e => e.Iatacode, "IX_Airlines_IATACode");

            entity.HasIndex(e => e.Icaocode, "IX_Airlines_ICAOCode");

            entity.Property(e => e.Iatacode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("IATACode");
            entity.Property(e => e.Icaocode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ICAOCode");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<AirlineCountry>(entity =>
        {
            entity.HasIndex(e => e.AirlineId, "IX_AirlineCountries_Airline");

            entity.HasIndex(e => e.CountryId, "IX_AirlineCountries_Country");

            entity.HasOne(d => d.Airline).WithMany(p => p.AirlineCountries)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("FK_AirlineCountries_Airlines");

            entity.HasOne(d => d.Country).WithMany(p => p.AirlineCountries)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AirlineCountries_Countries");
        });

        modelBuilder.Entity<AirlineReview>(entity =>
        {
            entity.HasIndex(e => e.AirlineId, "IX_AirlineReviews_Airline");

            entity.Property(e => e.Aircraft).HasMaxLength(150);
            entity.Property(e => e.OverallRating).HasDefaultValue((short)1);
            entity.Property(e => e.ReviewTitle).HasMaxLength(250);
            entity.Property(e => e.Route).HasMaxLength(150);

            entity.HasOne(d => d.Airline).WithMany(p => p.AirlineReviews)
                .HasForeignKey(d => d.AirlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AirlineReviews_Airlines");
        });

        modelBuilder.Entity<AirlineReviewAspect>(entity =>
        {
            entity.HasIndex(e => e.AirlineReviewId, "IX_AirlineReviewAspects_AirlineReview");

            entity.HasIndex(e => e.ReviewAspectId, "IX_AirlineReviewAspects_Aspect");

            entity.HasOne(d => d.AirlineReview).WithMany(p => p.AirlineReviewAspects)
                .HasForeignKey(d => d.AirlineReviewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AirlineReviewAspects_AirlineReviews");

            entity.HasOne(d => d.ReviewAspect).WithMany(p => p.AirlineReviewAspects)
                .HasForeignKey(d => d.ReviewAspectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AirlineReviewAspects_ReviewAspects");
        });

        modelBuilder.Entity<Airport>(entity =>
        {
            entity.HasIndex(e => e.AirportCode, "IX_Airports_AirportCode").IsUnique();

            entity.HasIndex(e => e.CountryId, "IX_Airports_Country");

            entity.HasIndex(e => e.Iatacode, "IX_Airports_IATACode");

            entity.HasIndex(e => e.RegionId, "IX_Airports_Region");

            entity.Property(e => e.AirportCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(250);
            entity.Property(e => e.GpsCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HomeLink).HasMaxLength(500);
            entity.Property(e => e.Iatacode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("IATACode");
            entity.Property(e => e.LocalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Municipality).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.WikipediaLink).HasMaxLength(500);

            entity.HasOne(d => d.Country).WithMany(p => p.Airports)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Airports_Countries");

            entity.HasOne(d => d.Region).WithMany(p => p.Airports)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_Airports_Regions");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_Countries_Code").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Continent)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.WikipediaLink).HasMaxLength(250);
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasIndex(e => e.AirlineId, "IX_Flights_Airline");

            entity.HasIndex(e => e.DestinationAirportId, "IX_Flights_DestinationAirport");

            entity.HasIndex(e => e.SourceAirportId, "IX_Flights_SourceAirport");

            entity.Property(e => e.TailNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Airline).WithMany(p => p.Flights)
                .HasForeignKey(d => d.AirlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Flights_Airlines");

            entity.HasOne(d => d.DestinationAirport).WithMany(p => p.FlightDestinationAirports)
                .HasForeignKey(d => d.DestinationAirportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Flights_Airports_Destination");

            entity.HasOne(d => d.SourceAirport).WithMany(p => p.FlightSourceAirports)
                .HasForeignKey(d => d.SourceAirportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Flights_Airports_Source");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_Regions_Code").IsUnique();

            entity.HasIndex(e => e.CountryId, "IX_Regions_Country");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Keywords).HasMaxLength(100);
            entity.Property(e => e.LocalCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.WikipediaLink).HasMaxLength(100);

            entity.HasOne(d => d.Country).WithMany(p => p.Regions)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regions_Countries");
        });

        modelBuilder.Entity<ReviewAspect>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Code)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RouteEntity>(entity =>
        {
            entity.HasIndex(e => e.AirlineId, "IX_Routes_Airline");

            entity.HasIndex(e => e.DestAirportId, "IX_Routes_DestinationAirport");

            entity.HasIndex(e => e.SourceAirportId, "IX_Routes_SourceAirport");

            entity.Property(e => e.CodeShare).HasMaxLength(50);
            entity.Property(e => e.Equipment).HasMaxLength(50);

            entity.HasOne(d => d.Airline).WithMany(p => p.Routes)
                .HasForeignKey(d => d.AirlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Routes_Airlines");

            entity.HasOne(d => d.DestAirport).WithMany(p => p.RouteDestAirports)
                .HasForeignKey(d => d.DestAirportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Routes_Airports_Destination");

            entity.HasOne(d => d.SourceAirport).WithMany(p => p.RouteSourceAirports)
                .HasForeignKey(d => d.SourceAirportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Routes_Airports_Source");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
