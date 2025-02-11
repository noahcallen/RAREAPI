namespace RARE.Models;

public class User
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string Bio { get; set; }
  public string Username { get; set; }
  public string Password { get; set; }
  public DateTime CreatedOn { get; set; }
  public List<Subscription> Subscriptions { get; set; }
  public List<PostReaction> PostReactions { get; set; }
  public List<Comment> Comments { get; set; }
  public List<Post> Posts { get; set; }
}
