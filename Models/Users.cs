namespace RAREAPI.Models;

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

  public User(int id, string firstName, string lastName, string email, string bio, string username, string password)
  {
    Id = id;
    FirstName = firstName;
    LastName = lastName;
    Email = email;
    Bio = bio;
    Username = username;
    Password = password;
    Subscriptions = subscriptions ?? new List<Subscription>();
    PostReactions = postReactions ?? new List<PostReaction>();
    Comments = comments ?? new List<Comment>();
    Posts = posts ?? new List<Post>();
  }
}
