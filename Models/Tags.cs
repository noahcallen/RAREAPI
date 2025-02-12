namespace RAREAPI.Models;

public class Tag
{
  public int Id { get; set; }
  public string Label { get; set; }
  public List<PostTag> PostTags { get; set; }

  public Tag(int id, string label, List<PostTag> postTags)
  {
    Id = id;
    Label = label;
    PostTags = postTags;
  }
}
