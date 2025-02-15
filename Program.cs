using System.Text.Json.Serialization;
using RAREAPI.Models;



// ============================================== DATA SOURCE ==============================================

List<User> users = new List<User>
{
    new User(1, "Tion", "Blackmon", "tion.blackmon@rare_api.com", "Best bio ever", "tionb_rare", "N@cho"),
    new User(2, "Noah", "Allen", "Noah.Allen@rare_api.com", "Passionate about coding and coffee.", "noahallen_rare", "C0ffeeLover"),
    new User(3, "Sirena", "Foster", "Sirena.Foster@rare_api.com", "Aspiring game developer and tech geek.", "sirenafoster_rare", "G@m3rX"),
    new User(4, "Brian", "Suttles", "Brian.Suttles@rare_api.com", "Lover of books, music, and late-night coding.", "briansuttles_rare", "B00kworm"),
    new User(5, "Ethan", "Martinez", "ethan.martinez@rare_api.com", "Building the future one app at a time.", "ethanm_rare", "D3vLife"),
    new User(6, "Ava", "Hernandez", "ava.hernandez@rare_api.com", "Traveler, foodie, and web dev enthusiast.", "avah_rare", "Gl0beTrotter")
};

List<Comment> comments = new List<Comment>
{
    new Comment(1, 2, 5, "This is an awesome post! Really enjoyed reading it.", users[1]),
    new Comment(2, 3, 5, "Great insights! Thanks for sharing.", users[2]),
    new Comment(3, 4, 7, "This helped me understand the topic better.", users[3]),
    new Comment(4, 5, 3, "I totally agree with your perspective!", users[4]), // Fixed from users[5]
    new Comment(5, 6, 1, "Love this content! Keep it coming.", users[4]) // No change needed
};

List<Tag> tags = new List<Tag>
{
    new Tag(1, "Software Engineering"),
    new Tag(2, "AI"),
    new Tag(3, "Cloud"),
    new Tag(4, "Cybersecurity"),
    new Tag(5, "Data Science"),
    new Tag(6, "Lifestyle"),
};
List<Category> categories = new List<Category>
{
    new Category(1, "Web Development", new List<Post>()),
    new Category(2, "Artificial Intelligence", new List<Post>()),
    new Category(3, "Cloud Computing", new List<Post>()),
    new Category(4, "Cybersecurity", new List<Post>()),
    new Category(5, "Data Science", new List<Post>()),
    new Category(6, "Software Engineering", new List<Post>())
};

List<Subscription> subscriptions = new List<Subscription>
{
    new Subscription(1, 1, 2, new DateTime(2025, 02, 12)),
    new Subscription(2, 4, 3, new DateTime(2025, 02, 11)),
    new Subscription(3, 5, 2, new DateTime(2025, 02, 13)),
    new Subscription(4, 6, 4, new DateTime(2025, 02, 10)),
    new Subscription(5, 3, 1, new DateTime(2025, 02, 09))
};

List<Reaction> reactions = new List<Reaction>
{
    new Reaction(1, "🔥"),
    new Reaction(2, "😂"),
    new Reaction(3, "❤️"),
    new Reaction(4, "👍"),
    new Reaction(5, "😮"),
    new Reaction(6, "😢"),
    new Reaction(7, "👏"),
    new Reaction(8, "🎉")
};

// Step 1: Declare posts list without postTags initially
List<Post> posts = new List<Post>();

// Step 2: Define postTags now that posts exist
List<PostTag> postTags = new List<PostTag>
{
    new PostTag(1, 2, tags[1], posts.Count > 0 ? posts[0] : null), // AI tag for "The Future of AI"
    new PostTag(1, 5, tags[4], posts.Count > 1 ? posts[0] : null), // Data Science tag for "The Future of AI"

    new PostTag(2, 1, tags[0], posts.Count > 1 ? posts[1] : null), // Software Engineering tag for "Web Development in 2025"
    new PostTag(2, 6, tags[5], posts.Count > 1 ? posts[1] : null), // Lifestyle tag for "Web Development in 2025"

    new PostTag(3, 3, tags[2], posts.Count > 2 ? posts[2] : null), // Cloud tag for "Cloud Security Best Practices"
    new PostTag(3, 4, tags[3], posts.Count > 2 ? posts[2] : null), // Cybersecurity tag for "Cloud Security Best Practices"

    new PostTag(4, 5, tags[4], posts.Count > 3 ? posts[3] : null), // Data Science tag for "Data Science and AI: A Perfect Match"
    new PostTag(4, 2, tags[1], posts.Count > 3 ? posts[3] : null), // AI tag for "Data Science and AI: A Perfect Match"

    new PostTag(5, 1, tags[0], posts.Count > 4 ? posts[4] : null), // Software Engineering tag for "Building Scalable Applications"
    new PostTag(5, 3, tags[2], posts.Count > 4 ? posts[4] : null)  // Cloud tag for "Building Scalable Applications"
};

// Step 3: Now define posts with postTags assigned properly
posts = new List<Post>
{
    new Post(1, 1, "The Future of AI", new DateTime(2025, 02, 01),
        "AI is evolving rapidly. Here’s what to expect in the next decade.",
        true,
        new List<Comment> { comments[0], comments[1] }, // Assigning comments
        new List<PostTag> { postTags[0], postTags[1] }, // Assigning post tags
        users[0],
        categories[1]),

    new Post(2, 2, "Web Development in 2025", new DateTime(2025, 01, 25),
        "The latest trends in web development, from frameworks to design.",
        true,
        new List<Comment> { comments[2] },
        new List<PostTag> { postTags[2], postTags[3] },
        users[1],
        categories[0]),

    new Post(3, 3, "Cloud Security Best Practices", new DateTime(2025, 01, 20),
        "How to secure your cloud infrastructure in 2025.",
        true,
        new List<Comment> { comments[3] },
        new List<PostTag> { postTags[4], postTags[5] },
        users[2],
        categories[2]),

    new Post(4, 4, "Data Science and AI: A Perfect Match", new DateTime(2025, 01, 15),
        "Exploring how AI and data science work together for better insights.",
        true,
        new List<Comment> { comments[4], comments[0] },
        new List<PostTag> { postTags[6], postTags[7] },
        users[3],
        categories[4]),

    new Post(5, 5, "Building Scalable Applications", new DateTime(2025, 01, 10),
        "A guide to architecting scalable applications in the modern era.",
        true,
        new List<Comment> { comments[1], comments[3] },
        new List<PostTag> { postTags[8], postTags[9] },
        users[4],
        categories[5])
};

foreach (var post in posts)
{
    post.Category.Posts.Add(post);
}

List<PostReaction> postReactions = new List<PostReaction>
{
    new PostReaction(1, 3, 2, 1, reactions[3], users[2], posts[4]),
    new PostReaction(2, 2, 4, 2, reactions[2], users[4], posts[4]), // Fixed from posts[5] → posts[4]
    new PostReaction(3, 3, 3, 3, reactions[1], users[3], posts[3]),
    new PostReaction(4, 1, 2, 4, reactions[4], users[1], posts[2]),
    new PostReaction(5, 5, 5, 5, reactions[7], users[5], posts[4]) // Fixed from users[6] → users[5], posts[5] → posts[4]
};

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Fix for cycle error
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// POST ENDPOINTS
app.MapPost("/tags", (Tag tagPayload) =>
{
    tagPayload.Id = tags.Max(tP => tP.Id) + 1;
    tags.Add(tagPayload);
    return Results.Ok(tags);
});
app.MapPost("/reactions", (Reaction reactionPayload) =>
{
    reactionPayload.Id = reactions.Max(r => r.Id) + 1;
    reactions.Add(reactionPayload);
    return Results.Ok(reactions);
});

// GET ENDPOINTS

// Tags
app.MapGet("/tags", () => tags);
app.MapGet("/tags/{id}", (int id) => tags.FirstOrDefault(t => t.Id == id));

// Reactions
app.MapGet("/reactions", () => reactions);
app.MapGet("/reactions/{id}", (int id) => reactions.FirstOrDefault(r => r.Id == id));

// Categories
app.MapGet("/categories", () =>
{
    return Results.Ok(categories);
});

app.MapGet("/categories/{id}", (int id) =>
{
    var category = categories.FirstOrDefault(c => c.Id == id);
    return category is not null ? Results.Ok(category) : Results.NotFound("Category not found.");
});

// Comments
app.MapGet("/comments", () =>
{
    return Results.Ok(comments);
});

app.MapGet("/comments/{id}", (int id) =>
{
    var comment = comments.FirstOrDefault(c => c.Id == id);
    return comment is not null ? Results.Ok(comment) : Results.NotFound("Comment not found.");
});

// PostReactions

// Posts

// GET
app.MapGet("/posts", () =>
{
    return Results.Ok(posts);
});

app.MapGet("/posts/{id}", (int id) =>
{
    var post = posts.FirstOrDefault(p => p.Id == id);
    return post != null ? Results.Ok(post) : Results.NotFound($"Post with ID {id} not found.");
});

//DELETE
app.MapDelete("/posts/{id}", (int id) =>
{
    var post = posts.FirstOrDefault(p => p.Id == id);

    if (post == null)
    {
        return Results.NotFound();
    }
    posts.Remove(post);
    return Results.Ok(post);
});

app.MapDelete("/categories/{id}", (int id) =>
{
    var category = categories.FirstOrDefault(c => c.Id == id);
    if (category is null)
    {
        return Results.NotFound("Category not found.");
    }
    // Optional: Remove all posts associated with this category if needed.
    categories.Remove(category);
    return Results.NoContent();
});

app.MapDelete("/comments/{id}", (int id) =>
{
    var comment = comments.FirstOrDefault(c => c.Id == id);
    if (comment is null)
    {
        return Results.NotFound("Comment not found.");
    }
    comments.Remove(comment);
    return Results.NoContent();
});

//PUT
app.MapPut("/posts/{id}", (int id, Post post) =>
{
    Post postToUpdate = posts.FirstOrDefault(p => p.Id == id);
    int postIndex = posts.IndexOf(postToUpdate);
    if (postToUpdate == null)
    {
        return Results.NotFound();
    }
    if (id != post.Id)
    {
        return Results.BadRequest();
    }
    posts[postIndex] = postToUpdate;
    return Results.Ok();
});

//POST
app.MapPost("/posts", (Post post) =>
{
    if (post == null)
    {
        return Results.BadRequest("Invalid request body.");
    }

    post.Id = posts.Any() ? posts.Max(p => p.Id) + 1 : 1; // Auto-increment ID
    posts.Add(post);

    return Results.Created($"/posts/{post.Id}", post);
});

app.MapPost("/categories", (Category newCategory) =>
{
    newCategory.Id = categories.Any() ? categories.Max(c => c.Id) + 1 : 1;
    newCategory.Posts = new List<Post>();
    categories.Add(newCategory);
    return Results.Created($"/categories/{newCategory.Id}", newCategory);
});

app.MapPost("/comments", (Comment newComment) =>
{
    newComment.Id = comments.Any() ? comments.Max(c => c.Id) + 1 : 1;
    comments.Add(newComment);
    return Results.Created($"/comments/{newComment.Id}", newComment);
});

// Subscriptions

// Users
// GET
app.MapGet("/users", () =>
{
    return Results.Ok(users);
});

app.MapGet("/users/{id}", (int id) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);
    return user != null ? Results.Ok(user) : Results.NotFound($"User with ID {id} not found.");
});

//DELETE
app.MapDelete("/users/{id}", (int id) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);

    if (user == null)
    {
        return Results.NotFound();
    }
    users.Remove(user);
    return Results.Ok(user);
});

//PUT
app.MapPut("/users/{id}", (int id, User user) =>
{
    User userToUpdate = users.FirstOrDefault(u => u.Id == id);
    int userIndex = users.IndexOf(userToUpdate);
    if (userToUpdate == null)
    {
        return Results.NotFound();
    }
    if (id != user.Id)
    {
        return Results.BadRequest();
    }
    users[userIndex] = userToUpdate;
    return Results.Ok();
});

app.MapPut("/categories/{id}", (int id, Category updatedCategory) =>
{
    var existingCategory = categories.FirstOrDefault(c => c.Id == id);
    if (existingCategory is null)
    {
        return Results.NotFound("Category not found.");
    }
    existingCategory.Label = updatedCategory.Label;
    
    return Results.Ok(existingCategory);
});

app.MapPut("/comments/{id}", (int id, Comment updatedComment) =>
{
    var existingComment = comments.FirstOrDefault(c => c.Id == id);
    if (existingComment is null)
    {
        return Results.NotFound("Comment not found.");
    }
    existingComment.Content = updatedComment.Content;
    existingComment.PostId = updatedComment.PostId;
    existingComment.User = updatedComment.User;
    
    return Results.Ok(existingComment);
});


//POST
app.MapPost("/users", (User user) =>
{
    if (user == null)
    {
        return Results.BadRequest("Invalid request body.");
    }

    user.Id = users.Any() ? users.Max(u => u.Id) + 1 : 1; // Auto-increment ID
    users.Add(user);

    return Results.Created($"/users/{user.Id}", user);
});

app.Run();
