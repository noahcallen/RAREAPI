namespace RARE.Models;

public class PostReaction
{
  public int Id { get; set; }
  public int ReactionId { get; set; }
  public int UserId { get; set; }
  public int PostId { get; set; }
  public Reaction Reaction { get; set; }
  public User User { get; set; }
  public Post Post { get; set; }
}
