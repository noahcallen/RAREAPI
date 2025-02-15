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


// Step 1: Declare posts without postTags
List<Post> posts = new List<Post>
{
    new Post(1, 1, "The Future of AI", new DateTime(2025, 02, 01),
        "AI is evolving rapidly. Here’s what to expect in the next decade.",
        true,
        new List<Comment> { comments[0], comments[1] },
        new List<PostTag>(), // Empty for now
        users[0],
        categories[1]),

    new Post(2, 2, "Web Development in 2025", new DateTime(2025, 01, 25),
        "The latest trends in web development, from frameworks to design.",
        true,
        new List<Comment> { comments[2] },
        new List<PostTag>(), // Empty for now
        users[1],
        categories[0]),

    new Post(3, 3, "Cloud Security Best Practices", new DateTime(2025, 01, 20),
        "How to secure your cloud infrastructure in 2025.",
        true,
        new List<Comment> { comments[3] },
        new List<PostTag>(), // Empty for now
        users[2],
        categories[2]),

    new Post(4, 4, "Data Science and AI: A Perfect Match", new DateTime(2025, 01, 15),
        "Exploring how AI and data science work together for better insights.",
        true,
        new List<Comment> { comments[4] },
        new List<PostTag>(), // Empty for now
        users[3],
        categories[4]),

    new Post(5, 5, "Building Scalable Applications", new DateTime(2025, 01, 10),
        "A guide to architecting scalable applications in the modern era.",
        true,
        new List<Comment>(),
        new List<PostTag>(), // Empty for now
        users[4],
        categories[5])
};

// Step 2: Create postTags list
List<PostTag> postTags = new List<PostTag>
{
    new PostTag(1, 2, tags[1], posts[0]), // AI tag for "The Future of AI"
    new PostTag(1, 5, tags[4], posts[0]), // Data Science tag for "The Future of AI"

    new PostTag(2, 1, tags[0], posts[1]), // Software Engineering tag for "Web Development in 2025"
    new PostTag(2, 6, tags[5], posts[1]), // Lifestyle tag for "Web Development in 2025"

    new PostTag(3, 3, tags[2], posts[2]), // Cloud tag for "Cloud Security Best Practices"
    new PostTag(3, 4, tags[3], posts[2]), // Cybersecurity tag for "Cloud Security Best Practices"

    new PostTag(4, 5, tags[4], posts[3]), // Data Science tag for "Data Science and AI: A Perfect Match"
    new PostTag(4, 2, tags[1], posts[3]), // AI tag for "Data Science and AI: A Perfect Match"

    new PostTag(5, 1, tags[0], posts[4]), // Software Engineering tag for "Building Scalable Applications"
    new PostTag(5, 3, tags[2], posts[4])  // Cloud tag for "Building Scalable Applications"
};

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

// ENDPOINTS

// Categories

// Comments

// PostReactions

// Posts

// Tags

// PostReactions

// Subscriptions

// Tags

// Users

app.Run();
