using System.ComponentModel;

namespace RAREAPI.Models;

public class Post
{
  public int Id { get; set; }
  public int UserId { get; set; }
  public string Title { get; set; }
  public DateTime? PublicationDate { get; set; }
  public string Content { get; set; }
  public bool Approved { get; set; }
  public List<Comment> Comments { get; set; }
  public List<PostTag> PostTags { get; set; }
  public User User { get; set; }
  public Category Category { get; set; } // Ensure this matches the class name

  public Post(
    int id,
    int userId,
    string title,
    DateTime publicationDate,
    string content,
    bool approved,
    List<Comment> comments = null,
    List<PostTag> postTags = null,
    User user = null,
    Category category = null)
  {
    Id = id;
    UserId = userId;
    Title = title;
    PublicationDate = publicationDate;
    Content = content;
    Approved = approved;
    Comments = comments ?? new List<Comment>();
    PostTags = postTags ?? new List<PostTag>();
    User = user;
    Category = category;
  }
}
