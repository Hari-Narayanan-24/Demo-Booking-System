using Microsoft.EntityFrameworkCore;
using bookingSystem.Models;

namespace bookingSystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Club> Clubs => Set<Club>();
    public DbSet<Member> Members => Set<Member>();
    public DbSet<Booking> Bookings => Set<Booking>();
}
