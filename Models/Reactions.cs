namespace RAREAPI.Models;

public class PostReaction
{
  public int Id { get; set; }
  public int Emoji { get; set; }
  public List<PostReaction> PostReactions { get; set; }

  public PostReaction(int id, int emoji)
  {
    Id = id;
    Emoji = emoji;
  }
}
