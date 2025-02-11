namespace RARE.Models;

public class PostReaction
{
  public int Id { get; set; }
  public int Emoji { get; set; }
  public List<PostReaction> PostReactions { get; set; }
}
