namespace bookingSystem.Models;

public class Booking
{
    public int Id { get; set; }
    public int ClubId { get; set; }
    public int MemberId { get; set; }
    public DateTime TimeUtc { get; set; }
}
