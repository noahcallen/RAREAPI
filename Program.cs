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
    new Comment(2, 3, 5, "Great insights! Thanks for sharing.",users[2]),
    new Comment(3, 4, 7, "This helped me understand the topic better.",users[3]),
    new Comment(4, 5, 3, "I totally agree with your perspective!",users[5]),
    new Comment(5, 6, 1, "Love this content! Keep it coming.", users[4])
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

// PostTags

// PostReactions

// Subscriptions

// PostTags

// Users

app.Run();
