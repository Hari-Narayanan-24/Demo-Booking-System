namespace bookingSystem.DTOs;

public class CreateBookingDto
{
    public int ClubId { get; set; }
    public int MemberId { get; set; }
    public DateTime TimeUtc { get; set; }
}
