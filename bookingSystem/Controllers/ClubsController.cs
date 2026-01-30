using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bookingSystem.Data;
using bookingSystem.DTOs;
using bookingSystem.Models;

namespace bookingSystem.Controllers;

[ApiController]
[Route("clubs")]
public class ClubsController : ControllerBase
{
    private readonly AppDbContext _db;

    public ClubsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateClubDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
            return BadRequest("Name is required");

        var club = new Club { Name = dto.Name.Trim() };

        _db.Clubs.Add(club);
        await _db.SaveChangesAsync();

        return Ok(club);
    }

    [HttpGet("{clubId}/bookings")]
    public async Task<IActionResult> GetBookings(int clubId)
    {
        var bookings = await _db.Bookings
            .Where(b => b.ClubId == clubId)
            .OrderBy(b => b.TimeUtc)
            .ToListAsync();

        return Ok(bookings);
    }
}
