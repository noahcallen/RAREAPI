namespace RARE.Models;

public class Tag
{
  public int Id { get; set; }
  public string Label { get; set; }
  public List<PostTag> PostTags { get; set; }
}
