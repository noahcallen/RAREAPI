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
    new Comment(1, 2, 5, "This is an awesome post! Really enjoyed reading it.", ),
    new Comment(2, 3, 5, "Great insights! Thanks for sharing."),
    new Comment(3, 4, 7, "This helped me understand the topic better."),
    new Comment(4, 5, 3, "I totally agree with your perspective!"),
    new Comment(5, 6, 1, "Love this content! Keep it coming.")
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
