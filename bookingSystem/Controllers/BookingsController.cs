using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bookingSystem.Data;
using bookingSystem.DTOs;
using bookingSystem.Models;

namespace bookingSystem.Controllers;

[ApiController]
[Route("bookings")]
public class BookingsController : ControllerBase
{
    private readonly AppDbContext _db;

    public BookingsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBookingDto dto)
    {
        if (dto.ClubId <= 0) return BadRequest("ClubId must be > 0");
        if (dto.MemberId <= 0) return BadRequest("MemberId must be > 0");
        if (dto.TimeUtc == default) return BadRequest("TimeUtc is required");

        var member = await _db.Members.FirstOrDefaultAsync(m => m.Id == dto.MemberId);
        if (member is null) return NotFound($"Member {dto.MemberId} not found");

        if (member.ClubId != dto.ClubId)
            return BadRequest("Member does not belong to the given ClubId");

        var booking = new Booking
        {
            ClubId = dto.ClubId,
            MemberId = dto.MemberId,
            TimeUtc = dto.TimeUtc
        };

        _db.Bookings.Add(booking);
        await _db.SaveChangesAsync();

        return Ok(booking);
    }
}
