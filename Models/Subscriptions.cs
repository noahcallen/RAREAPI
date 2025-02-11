namespace RARE.Models;

public class Subscription
{
  public int Id { get; set; }
  public int FollowerId { get; set; }
  public int AuthorId { get; set; }
  public DateTime CreatedOn { get; set; }
  public User User { get; set; }
}
