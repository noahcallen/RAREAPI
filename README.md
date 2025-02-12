# Rare Publishing Platform 🚀

## Overview ✨
Welcome to the Rare Publishing Platform—a fresh, modern space where readers and writers unite to share compelling stories and ideas. Gone are the days of mailing in your submissions; now, your creativity can shine online instantly! 🎉

## What’s It All About? 📚
Rare Publishing is all about connecting passionate storytellers and eager readers. This dynamic platform enables users to:
- **Submit Posts:** Share your stories, ideas, and insights with the world.
- **Update Content:** Keep your posts fresh and engaging.
- **Comment & Connect:** Join the conversation by commenting on posts.
- **Discover with Ease:** Navigate content effortlessly through intuitive tags and categories.

Our goal is to make content discovery as enjoyable as diving into your favorite book—quick, intuitive, and always inspiring. ⚡

## Requirements 🔧
Before you dive in, make sure you have these essentials:
- **.NET 8.0 SDK:** [Download Here](https://dotnet.microsoft.com/download/dotnet/8.0)
- **Git:** [Download Here](https://git-scm.com/)
- **Postman:** [Download Here](https://www.postman.com/) (for API testing)
- A SQL database server (or the appropriate database setup based on your configuration)

## Getting Started 🚀

### Clone the Repository
1. **Create a directory** for your project workspace. For example:
   ```bash
   mkdir -p ~/workspace/csharp/rare
   cd ~/workspace/csharp/rare
   git clone <repository_url>
   cd RAREAPI
2. **Create a new Web API project using:**
   ```bash
   dotnet new webapi -n RAREAPI --framework net8.0
3. **Build the project to ensure everything is in order:**
   ```bash
   dotnet build
4. **Run The Project:**
   ```bash
   dotnet run
The API will be accessible at `https://localhost:5001` (or your configured port).

## Project Structure & .gitignore

We follow a clean, modular structure:

- **Controllers:** Houses the API endpoints.
- **Models:** Contains data structures and entities.
- **Data/Services:** Manages database contexts and business logic.
- **.gitignore:** Ensures sensitive and build files are not tracked.

## Our Journey So Far 🌟

The groundwork is laid:

- **User Management:** Login and registration are already implemented.
- **Post Management:** Create, update, delete, and view posts.
- **Comments:** Engage with posts by adding comments.
- **Tags & Categories:** Organize content for seamless browsing.
- **Subscriptions & Reactions:** Follow your favorite authors and react to posts with fun emojis.

In this sprint, every post is automatically published—no admin approvals needed—and image uploads are not supported. This MVP is just the beginning, with many more exciting features to come! 🚀

## Development Workflow & Collaboration 🤝

- **Issue Tracking:** We manage our tasks using GitHub Issues, each with detailed user stories and acceptance criteria.
- **Sprint Planning:** Our team collaborates on prioritizing tickets and planning each sprint.
- **Testing:** Every endpoint is thoroughly tested using Postman to ensure a smooth experience.

## Behind the Scenes 🛠️

Built on the robust .NET 8 framework, our back-end leverages modern technology to deliver a fast, secure, and scalable API. The thoughtfully designed database (refer to the ERD) supports everything from user profiles to post analytics.

## Looking Ahead 🔮

We're on a mission to revolutionize digital storytelling—making it easier than ever for ideas to flourish and voices to be heard. Whether you're a developer, writer, or reader, your journey with Rare Publishing is just beginning. Together, we’re creating a vibrant community where creativity meets innovation.

Happy coding and even happier reading! 📖❤️



