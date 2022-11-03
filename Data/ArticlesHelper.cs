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
                },
                new Article
                {
                    Id = 10,
                    Title = "Graduation!",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "This is your graduation from Console Apps! Find out how to start applying for jobs and what are the next steps in your coding journey.",
                    Area = Area.Console
                }
            };
        }
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Calculator",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "In your first project, you’ll create a calculator with the help of Microsoft's Documentation",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 2,
                    Title = "Habit Logger",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build a logger for a habit of choice. Learn how to interact with a database using SQLite and to get and validate user input",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 3,
                    Title = "Coding Tracker",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Track your coding hours. Learn how to deal with dates, to use separation of concerns and use your first external library to enhance your application",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 4,
                    Title = "Flashcards",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Building stacks of flashcards and a study functionality. Learn to deal with linked databases using SQL Server and to use Data Transfer Objects",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 5,
                    Title = "Drinks Info",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build a console app to consume an external API with HTTP Requests with C#",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 6,
                    Title = "Phone Book",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Now you have basic understanding of SQL, it’s time to learn the basics of Entity Framework with a CRUD Phone Book Console App",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 7,
                    Title = "Shifts Logger",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build an App for shift workers to log their hours. In this app you’ll learn how to build a Web API and consume it with a Console App",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 8,
                    Title = "Exercise Tracker",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Learn the repository pattern, the most common design pattern for interaction with databases",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 9,
                    Title = "Sports Results Notifier",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Learn how to create a web crawler and send e-mails using C#",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 10,
                    Title = "Excel Reader",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Learn how to read data from an Excel Sheet into a real database using SQL",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 11,
                    Title = "Unit Testing",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "The last piece of the puzzle before moving on to  front-end. Learn to test the business logic of your applications",
                    Area = Area.Console
                },
                new Project
                {
                    Id = 12,
                    Title = "Portfolio",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Time to create a portfolio! Let’s present your work using a nice front-end technology of your choice",
                    Area = Area.StartApplying
                },
                new Project
                {
                    Id = 13,
                    Title = "Resume",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "The last step before start applying for jobs. Let’s build a nice resume before hit the Apply button",
                    Area = Area.StartApplying
                },
                new Project
                {
                    Id = 14,
                    Title = "Water Drinking Logger",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build your first full-stack app with ASP.NET C# Razor Pages and ADO.NET",
                    Area = Area.MVC
                },
                new Project
                {
                    Id = 15,
                    Title = "Movies",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build your first full-stack app with ASP.NET C# MVC and Entity Framework",
                    Area = Area.MVC
                },
                new Project
                {
                    Id = 16,
                    Title = "Todo List",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build your first MVC application with C#, Razor Syntax, Javascript and Bootstrap",
                    Area = Area.MVC
                },
                new Project
                {
                    Id = 17,
                    Title = "Budget",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build a personal finance app with multiple related tables in the back-end",
                    Area = Area.MVC
                },
                new Project
                {
                    Id = 18,
                    Title = "Authentication and Authorization",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Learn how to secure your app with ASP.NET Core Identity",
                    Area = Area.MVC
                },
                new Project
                {
                    Id = 19,
                    Title = "Ecommerce",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build a fully functioning ecommerce for products of your choice",
                    Area = Area.MVC
                },
                new Project
                {
                    Id = 20,
                    Title = "E-Commerce Admin",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build an administration page for the e-commerce you build in project 6, using Asp.NET Role-based Authentication",
                    Area = Area.MVC
                },
                new Project
                {
                    Id = 21,
                    Title = "Tour of Heroes",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Learn the basics of Angular by building a purely front-end app using the documentation",
                    Area = Area.Angular
                },
                new Project
                {
                    Id = 22,
                    Title = "Coffee Tracker",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Track your coffee consumption with a C# Web Api and Angular",
                    Area = Area.Angular
                },
                new Project
                {
                    Id = 23,
                    Title = "Sleep Tracker",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build on your Angular foundation with an app to log and generate reports about your sleep",
                    Area = Area.Angular
                },
                new Project
                {
                    Id = 24,
                    Title = "Quiz Game",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build a highly interactive Quiz Game with Angular and Angular Material",
                    Area = Area.Angular
                },
                new Project
                {
                    Id = 25,
                    Title = "Tic-Tac-Toe",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "A very simple project to easy you into with this rich framework. You’ll be consuming an Api of your choice",
                    Area = Area.React
                },
                new Project
                {
                    Id = 26,
                    Title = "Call an External API",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build a simple Get Endpoint with .NET and fetch data from it using React",
                    Area = Area.React
                },
                new Project
                {
                    Id = 27,
                    Title = "Shopping List",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build your first full CRUD app with React, calling a .NET Web API",
                    Area = Area.React
                },
                new Project
                {
                    Id = 28,
                    Title = "Friends Manager",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build an app that will help you monitor and cultivate your friendships managing state with Redux",
                    Area = Area.React
                },
                new Project
                {
                    Id = 29,
                    Title = "Wardrobe Inventory",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Get started with Blazor by building an inventory for your clothes. With pictures!",
                    Area = Area.Blazor
                },
                new Project
                {
                    Id = 30,
                    Title = "Memory Game",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build a simple memory game where users will train their brain and track results",
                    Area = Area.Blazor
                },
                new Project
                {
                    Id = 31,
                    Title = "Food Journal",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Log your food habits in your first CRUD Blazor App",
                    Area = Area.Blazor
                },
                new Project
                {
                    Id = 32,
                    Title = "Sports Statistics",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build an application to track the performance of a sports team in real time",
                    Area = Area.Blazor
                },
                new Project
                {
                    Id = 33,
                    Title = "Math Game",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Start your native app development journey building a simple game with the four basic mathematical operations",
                    Area = Area.MAUI
                },
                new Project
                {
                    Id = 34,
                    Title = "Books to Read",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build an app to keep track of reading activity using the MVVM pattern",
                    Area = Area.MAUI
                },
                new Project
                {
                    Id = 35,
                    Title = "Monkeys Data",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Build an advanced Mobile UI to present data about Monkeys, using Geolocation to show which monkey is closest to you",
                    Area = Area.MAUI
                },
                new Project
                {
                    Id = 36,
                    Title = "Warehouse Admin",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Track warehouse operations using a complex data model with Maui",
                    Area = Area.MAUI
                },
                new Project
                {
                    Id = 37,
                    Title = "Deploying a Simple App",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Start with Azure creating an account and deploying a simple app without a database",
                    Area = Area.Azure
                },
                new Project
                {
                    Id = 38,
                    Title = "Deploying a full-stack .NET app",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Deploy a crud app from the .NET ecosystem along with a database server",
                    Area = Area.Azure
                },
                new Project
                {
                    Id = 39,
                    Title = "Deploy a full-stack .NET + JS Framework app",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Deploy a full-stack app using a JS framework along with a .NET Web API",
                    Area = Area.Azure
                },
                new Project
                {
                    Id = 40,
                    Title = "Azure Functions",
                    IconUrl = "https://www.thecsharpacademy.com/wp-content/uploads/2021/12/icons8-baby-app-96.png",
                    Description = "Get started with serverless computing creating backend services directly on the cloud",
                    Area = Area.Azure
                }
            };
        }
    }
}
