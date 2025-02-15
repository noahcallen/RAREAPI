namespace RAREAPI.Models;

public class Comment
{
  public int Id { get; set; }
  public int AuthorId { get; set; }
  public int PostId { get; set; }
  public string Content { get; set; }
  public User User { get; set; }
  public Post ? Post { get; set; }

  public Comment(int id, int authorId, int postId, string content, User user)
  {
    Id = id;
    AuthorId = authorId;
    PostId = postId;
    Content = content;
    User = user;
  }
}
