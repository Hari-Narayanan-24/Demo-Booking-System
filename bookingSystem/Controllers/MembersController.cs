using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bookingSystem.Data;
using bookingSystem.DTOs;
using bookingSystem.Models;

namespace bookingSystem.Controllers;

[ApiController]
[Route("members")]
public class MembersController : ControllerBase
{
    private readonly AppDbContext _db;

    public MembersController(AppDbContext db)
    {
        _db = db;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateMemberDto dto)
    {
        if (dto.ClubId <= 0) return BadRequest("ClubId must be > 0");
        if (string.IsNullOrWhiteSpace(dto.Name)) return BadRequest("Name is required");

        var clubExists = await _db.Clubs.AnyAsync(c => c.Id == dto.ClubId);
        if (!clubExists) return NotFound($"Club {dto.ClubId} not found");

        var member = new Member
        {
            ClubId = dto.ClubId,
            Name = dto.Name.Trim()
        };

        _db.Members.Add(member);
        await _db.SaveChangesAsync();

        return Ok(member);
    }
}
