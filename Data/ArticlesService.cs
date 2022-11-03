using TCSA.Models;

namespace TCSA.Data
{
    public static class ArticlesHelper
    {
        public static List<Article> GetArticles()
        {
            return new List<Article>
            {
                new Article
                {
                    Id = 1,
                    Title = "Start From Scratch",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Learn to set up your developer environment and basic C# concepts to get you started.",
                    Area = Area.HowItWorks
                },
                new Article
                {
                    Id = 2,
                    Title = "Learn by Doing",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Dive into our projects, tailored to get you from absolute beginner to advanced, building your skills one step at a time.",
                    Area = Area.HowItWorks
                },
                new Article
                {
                    Id = 3,
                    Title = "Community Based",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "When you get stuck, reach out and we will help you figure out the solution, teaching you how to think like a professional developer. ",
                    Area = Area.HowItWorks
                },
                new Article
                {
                    Id = 4,
                    Title = "Get Job Ready",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "With our help, create a resume, build a portfolio and start jobseeking.",
                    Area = Area.HowItWorks
                },
                new Article
                {
                    Id = 5,
                    Title = "Start Here",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "This is your starting point. Click on the door to find out how the academy works and to read very important tips that will help you in your journey. ",
                    Area = Area.StartHere
                },
                new Article
                {
                    Id = 6,
                    Title = "Getting Help",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "You’ll get stuck. Many times. It’s the life of a developer. Find out how to solve problems like a professional programmer and where to get help.",
                    Area = Area.StartHere
                },
                new Article
                {
                    Id = 7,
                    Title = "Setting Up",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Learn how to set up your develop environment with .NET framework and Visual Studio so you can get ready to start coding.",
                    Area = Area.StartHere
                },
                new Article
                {
                    Id = 8,
                    Title = "C# Foundations",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Dive into basic C# syntax and control flow. You’ll learn just enough theory to have a solid foundation before jumping into our projects.",
                    Area = Area.StartHere
                },
                new Article
                {
                    Id = 9,
                    Title = "The Importance of Console Applications",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Building console applications will allow you to focus on the back end before diving into the complexities of front-end. Here’s why.",
                    Area = Area.StartHere
                }
            };
        }
    }
}
