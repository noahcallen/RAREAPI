namespace RARE.Models;

public class Categories
{
  public int Id { get; set; }
  public string Label { get; set; }
  public List<Post> Posts { get; set; }
}
