namespace RAREAPI.Models;

public class Categories
{
  public int Id { get; set; }
  public string Label { get; set; }
  public List<Post> Posts { get; set; }

  public Categories(int id, string label, List<Post> posts)
  {
    Id = id;
    Label = label;
    Posts = posts;
  }
}
