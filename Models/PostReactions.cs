namespace RAREAPI.Models;

public class PostReaction
{
  public int Id { get; set; }
  public int ReactionId { get; set; }
  public int UserId { get; set; }
  public int PostId { get; set; }
  public Reaction Reaction { get; set; }
  public User User { get; set; }
  public Post Post { get; set; }

  public PostReaction(
    int id,
    int reactionId,
    int userId,
    int postId,
    Reaction reaction = null,
    User user = null,
    Post post = null)
  {
    Id = id;
    ReactionId = reactionId;
    UserId = userId;
    PostId = postId;
    Reaction = reaction;
    User = user;
    Post = post;
  }
}
