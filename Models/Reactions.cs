namespace RAREAPI.Models;

public class Reaction
{
  public int Id { get; set; }
  public int Emoji { get; set; }
  public List<PostReaction> PostReactions { get; set; }

  public Reaction (int id, int emoji)
  {
    Id = id;
    Emoji = emoji;
  }
}
//test
