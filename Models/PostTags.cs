namespace RAREAPI.Models;

public class PostTag
{
  public int Id { get; set; }
  public int PostId { get; set; }
  public int TagId { get; set; }
  // public Post Post { get; set; }
  public Tag Tag { get; set; }

  public PostTag(int postId, int tagId, Tag tag)
  {
    PostId = postId;
    TagId = tagId;
    Tag = tag;
  }
}
