using RAREAPI.Models;

public class Subscription
{
  public int Id { get; set; }
  public int FollowerId { get; set; }
  public int AuthorId { get; set; }
  public DateTime CreatedOn { get; set; }
  public User User { get; set; }

  public Subscription(
    int id,
    int followerId,
    int authorId,
    DateTime createdOn,
    User user = null)
  {
    Id = id;
    FollowerId = followerId;
    AuthorId = authorId;
    CreatedOn = createdOn;
    User = user;
  }
}
//test2
