namespace RAREAPI.Models;

public class Category 
{
  public int Id { get; set; }
  public string Label { get; set; }
  public List<Post> Posts { get; set; }

  public Category(int id, string label, List<Post> posts = null)
  {
    Id = id;
    Label = label;
    Posts = posts ?? new List<Post>(); 
  }
}
