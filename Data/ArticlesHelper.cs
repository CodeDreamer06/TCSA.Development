using TCSA.Models;

namespace TCSA.Data;

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
                IconUrl = "2021/12/icons8-baby-app-96.png",
                Description = "Learn to set up your developer environment and basic C# concepts to get you started.",
                Area = Area.HowItWorks

            },
            new Article
            {
                Id = 2,
                Title = "Learn by Doing",
                IconUrl = "2022/05/icons8-direction-512.png",
                Description = "Dive into our projects, tailored to get you from absolute beginner to advanced, building your skills one step at a time.",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 3,
                Title = "Community Based",
                IconUrl = "2021/12/icons8-ask-96.png",
                Description = "When you get stuck, reach out and we will help you figure out the solution, teaching you how to think like a professional developer. ",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 4,
                Title = "Get Job Ready",
                IconUrl = "2021/12/icons8-submit-resume-80.png",
                Description = "With our help, create a resume, build a portfolio and start jobseeking.",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 5,
                Title = "Start Here",
                IconUrl = "2021/12/icons8-door-80.png",
                Description = "This is your starting point. Click on the door to find out how the academy works and to read very important tips that will help you in your journey. ",
                Area = Area.StartHere,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Hi! Welcome to The C# Academy!"
                            },
                            new Paragraph
                            {
                                Body = "My name is Pablo and it’s a pleasure to have the opportunity to help you in your journey. I hope The C# Academy will give you some direction! I’m a self-taught software developer and got my first job at 39 after two years of relentless, daily, coding practice. If you want to know more about my journey, please read this blog post."
                            },
                            new Paragraph
                            {
                                Body = "I strongly believe most people have what it takes to become a software developer but are lacking a clear path and we’re here to help with that. This is a completely free resource. If you’re wondering why I do this, here’s the reason: By helping you, I’m helping myself. I become a better coder, teacher and person. The world needs more community and people getting together to solve problems. And I want to contribute to the world. 😁"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What to Expect",
                        ImgUrl = "2021/12/icons8-in-doubt-skin-type-3-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "We won’t teach you how to code. We’ll teach you how to teach yourself and nudge you in the right direction. You have to do it yourself if you want to have any chance of succeeding in a real job. Even if you pay us a lot of money to be your full time code teacher, if you don’t learn how to learn on your own you don’t have a chance in this industry."
                            },
                            new Paragraph
                            {
                                Body = "That being said, you will have all the support needed to go from beginner to advanced. You’ll never be alone. If you get lost or stuck during your journey, you’ll always find help in our Discord community. The things we can help you with are: a clear pathway, feedback on your journey, organization and community."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Community",
                        ImgUrl = "2021/12/icons8-community-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Learning how to code, you’ll spend hour upon hour by yourself, in front of your computer, banging your head against the wall, solving problems. Chances are you’ll feel lonely and isolated at times. It makes a difference connecting with people that are going through the same. You’re not alone! We’re here to help. Join us on Discord and if the link isn’t working add me and send me a personal message at pablocappuccino#4729. No message will be left unanswered."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Clear Pathway",
                        ImgUrl = "2021/12/icons8-ambition-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s very important to have clear stepping stones and benchmarks as references for your work. It’s easy to feel lost in the sea of information and possibilities the web gives us. You need to give your brain a rest by laying out a pathway that will be in the back of your mind throughout your journey. Decision fatigue is exhausting and frustrating. It can undermine your progress and ultimately lead to failure."
                            },
                            new Paragraph
                            {
                                Body = "At the C# Academy you can find a roadmap with all the steps necessary to become a full stack web developer. It’s not necessarily linear and the lines between the stages are blurry. You’ll be constantly revisiting the previous items on the checklist, at any given time during your progress. Here’s the roadmap."
                            },
                            new Paragraph
                            {
                                Body = "You can also tweak it and lay it out as you wish, but whatever you do, I recommend you have a list of clear steps easily accessible and if possible memorized."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Feedback",
                        ImgUrl = "2021/12/icons8-feedback-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "As we progress through our road map, you’ll be building projects, a portfolio, a resume and preparing for interviews. We’ll give you feedback on all of those. Each of our projects have a list of requirements, but there are always details in the design, implementation and code style that are open to your own individuality. We encourage you try things on your own and we’ll only suggest corrections that are considered bad practice."
                            },
                            new Paragraph
                            {
                                Body = "We have a list of projects to get you started and new projects will be added constantly. If you want to know our view on what to build, please check this blog post. It will give you ideas to think of your own projects, and some perspective on what types of projects are effective for a portfolio."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Organisation",
                        ImgUrl = "2021/12/icons8-tidy-shelf-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You need to do some housekeeping before starting.  I’m sure there are messy disorganised high achievers in this world. But in my experience, creating the right environment, organising your life and your priorities and removing the clutter (mental and physical) of your life will improve your chances of success. Here are some things to consider:"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Gear",
                        ImgUrl = "2021/12/icons8-equipment-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Get a good machine. I started with an old 2014 Dell. I quickly realised I needed something better and bought a 128GB 2019 Mac. About a year later I realised having Windows made things way easier for .Net development and I bought a 500GB 2020 Mac to have more space for a virtual machine. Two years later a bought a powerful HP/Windows machine so I could use the full potential of Microsoft’s tools for .NET developers.  I’m not rich, I just worked hard and saved the money to buy it. It’s part of my “I’ll do whatever it takes” mentality."
                            },
                            new Paragraph
                            {
                                Body = "A slow machine can be a nightmare. You can absolutely achieve your goal with a bad computer, but again, your life will be much easier if you get the latest computer. Or something close, second hand. You DON’T NEED Windows to become a .NET developer. Having a Windows machine does make things easier at first, but not only it’s not necessary, but using a different operating system will also teach you important skills such as using the command line and troubleshooting the .NET environment, which will ultimately make you a better developer. "
                            },
                            new Paragraph
                            {
                                Body = "Also, I highly recommend getting an extra screen. It doesn’t need to be fancy. You just need to be able to connect it to your computer. Watching a tutorial having to close your video every time you need to code will waste a ton of your time. Here’s a picture of my setup when I started. I got this screen from a friend that didn’t use it anymore. Please get one for yourself, it can be second hand, it just needs to work. If it’s a large screen, even better."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "2021/12/IMG_8392-768x576.jpg"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Time",
                        ImgUrl = "2021/12/icons8-timetable-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You have to carve out time in your life if you want to learn how to code. I admit it was easier for me because I worked from 11am so I would just wake up at 4am every day and code as much as I could."
                            },
                            new Paragraph
                            {
                                Body = "If you can do it first thing in the morning, it will be better. If you can’t, do it as soon as you can. If you leave it to bed time, while not impossible, it will be really hard to focus and absorb anything."
                            },
                            new Paragraph
                            {
                                Body = "You will have to say NO to requests for your time. I sacrificed relationships because I wasn’t willing to give up my morning to spend time with them. My morning is sacred, it’s coding time and unless a family member was dying (which never happened), I would be coding. Protect your time."
                            },
                            new Paragraph
                            {
                                Body = "Also, track your time. I’m a geek, so I track every hour of my day. You don’t need to go that far, but I suggest you track at least your coding hours. I always aimed for 28hs of programming per week. Even though I almost never achieved it, I never coded less than 20hs a week, in part due to the big goal. Start recording your results today and lay them out on a spreadsheet. Try to beat your daily, weekly and monthly records."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Notes",
                        ImgUrl = "2021/12/icons8-timetable-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You need to take notes. Don’t worry about taking notes about theoretical things you’re learning, unless that’s how you comprehend things. Instead, take notes about the steps you’re taking to complete a project and about errors you encountered and how you solved them. You will need those in the feature. "
                            },
                            new Paragraph
                            {
                                Body = "A combination of my notes and previous projects saves me many hours of head-banging. I use Roamresearch. I think it’s superior to anything I’ve ever used, but Evernote, Google Docs and even your computer’s notepad will do. Keep your notes organized."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "One Thing At A Time",
                        ImgUrl = "2021/12/icons8-to-do-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "I have a wandering mind, extreme curiosity and several areas of interest. If I don’t keep a tight leash on my mind, I jump around to the point I don’t get anything done. I can’t stress enough the importance of doing one thing at a time."
                            },
                            new Paragraph
                            {
                                Body = "Don’t work on 10 projects. One at a time! Actually, to be honest, I always work on two things, so If I get bored or stuck I can always jump to the other to make me feel better. But still, one of them has to be your main goal. "
                            },
                            new Paragraph
                            {
                                Body = "I know so many clever students who have been learning for a long time and have nothing to show for. No portfolio, no projects, nothing. And doing too many things is one of the reasons. "
                            },
                            new Paragraph
                            {
                                Body = "The same applies to your daily life. Don’t cram 20 tasks into your daily schedule. Do one or two big things a day and consider yourself successful for that day. My thing was always coding. If I did my four hours, I won the day. You can have a study goal and parallel goal such as running an important errand or something. But keep it achievable. You want to win your days."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Mindset",
                        ImgUrl = "2021/12/icons8-to-do-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "I read a lot. I attribute a lot of my success in my programming journey to the scope and depth that reading has given me. Actually, I don’t read, I listen. Books and podcasts. They are absolutely life-changing."
                            },
                            new Paragraph
                            {
                                Body = "If you don’t have some form of input in your life, you’re missing out. In our days technology gives access to curated information easily accessible at any time. Indirect mentorship through podcasts, audiobooks, youtube channels. Yet some of us think that we don’t need it, we know it all."
                            },
                            new Paragraph
                            {
                                Body = "There are a few exceptions out there, but the vast majority of high achievers, the people who run things in this world, are avid readers. If you don’t like it, start liking it. It will pay off. I promise."
                            },
                            new Paragraph
                            {
                                Body = "There are many books I could recommend but to keep it simple, the most important are:"
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "2021/12/40121378-678x1024.jpg",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Atomic Habits by James Clear – It will help you to get your habits in order. Backed by many amazing anecdotes and scientific studies, if you listen to it over and over, trust me, you’ll be a better person."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "2021/12/27213329-672x1024.jpg",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Atomic Habits by James Clear – It will help you to get your habits in order. Backed by many amazing anecdotes and scientific studies, if you listen to it over and over, trust me, you’ll be a better person."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What Happens From Here",
                        ImgUrl = "2021/12/icons8-where-what-quest-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Once you finish reading this page, join our Discord Community and introduce yourself.  If the link doesn’t work, add me via my nickname: pablocappuccino#4729. We can either work closely together with constant feedback and a clear plan, or you can roam free and get back to us whenever you need. "
                            },
                            new Paragraph
                            {
                                Body = "If you choose the first option, it’s important that you know that our objective is still to set you free to learn by yourself and make your own decisions. You can stick to our program, create your own projects or a combination of both.  There isn’t one way to achieve this. Keep in mind that it will be easier for me and other members of the academy to give feedback and review your code for the projects in our pathway, since we’ve completed them ourselves. But we will still help you with personal projects to the extent we can."
                            },
                            new Paragraph
                            {
                                Body = "If you choose the second option, I still recommend you join the discord community and follow the steps in the road map. Write it down somewhere and make sure you tick those boxes. The order doesn’t matter, but I do believe that if you tick the boxes in that plan you have a great chance of getting a job."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Final Word",
                        ImgUrl = "2021/12/icons8-whispering-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want instant rewards, or if you believe you’ll start earning six figures doing something that doesn’t require a lot of effort, this isn’t for you. If you can’t stand the long hours of hard work,  or if you don’t like getting stuck and taking days, sometimes weeks to fix a problem, you might not have the grit, or be passionate enough about coding to make this happen. Maybe this isn’t for you and that’s fine. It might sound harsh but that’s the reality of what it takes to become a programmer (and I would guess, to be good at anything for that matter)."
                            },
                            new Paragraph
                            {
                                Body = "Most people who start learning to code quit in less than 6 months. If you stick to it, imagine that in 2 years it’s highly likely you’ve got many interviews and got at least close to a job. Five years training consistently? You’ll probably not only be employed but also making very good money. Now imagine ten years consistently building stuff. I would say it’s impossible you’re not hired and earning great money."
                            },
                            new Paragraph
                            {
                                Body = "I’ll let Will Smith do the final talk, enjoy:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/MVVx8tzTJYg"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 6,
                Title = "Getting Help",
                IconUrl = "2021/12/icons8-helping-96.png",
                Description = "You’ll get stuck. Many times. It’s the life of a developer. Find out how to solve problems like a professional programmer and where to get help.",
                Area = Area.StartHere,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        ImgUrl= "2021/12/icons8-anxious-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Every developer, no matter the experience level, gets stuck, every single day. It’s very important to understand that it’s absolutely normal to spend hours, days, sometimes weeks, trying to solve one single problem. I’ve seen many programming students getting frustrated and quitting because they just don’t expect it to be this way. There’s no such thing as entering a flow state and having your project magically finished without hiccups. At least for most mortals."
                            },
                            new Paragraph
                            {
                                Body = "Every project is a bumpy road. When studying, every little thing you try to do will require some level of troubleshooting. In a professional environment, there will be a constant back-and-forth between developers, “product owners”, “quality assurance” professionals and stakeholders to make sure the requirements are being met."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Thought Patterns",
                        ImgUrl= "2021/12/icons8-headache-60.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The sooner you understand that this is the nature of the work, the better. Your attitude towards these errors is the single most important factor that will determine your success. I know it can be disheartening sometimes. I’ve been stuck with errors for weeks. So what kept me going? I have two thought patterns that I trained myself to use in difficult programming situations:"
                            },
                            new Paragraph
                            {
                                Body = "1 – Quitting is not an option.\r\n2 – “We have a drone on Mars”. If we are able to control a drone on Mars, THERE IS a solution for whatever programming problem I’m having."
                            },
                            new Paragraph
                            {
                                Body="Remember this: THERE IS A SOLUTION. It will take many years of programming to run into problems that haven’t been solved before. So if you stick to it, no matter how long it takes, you will solve it. So let’s see how we solve problems in software development."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Double Check Your Code",
                        ImgUrl= "2021/12/icons8-magnifying-glass-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "When something doesn’t work in your code, the first step is to double check it. Read it carefully, word by word. You’ll inevitably have typos, missing words, misplaced code and often times you’ll be able to fix things just by reading again with more attention."
                            },
                            new Paragraph
                            {
                                Body = "If you’re following a tutorial, check the instructors code again. You might have also missed something. In video tutorials, sometimes the teacher will slightly change the code and you’ll miss it because of editing. With time you’ll sharpen your attention to detail and make less of these mistakes, but always keep this tool up your sleeve."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Read The Error",
                        ImgUrl= "2021/12/icons8-error-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It might seem obvious, but even experienced developers sometimes just don’t read the errors. More often than not, the solution will be contained in the error message. Software these days is being written with special attention to error messages to help debugging and you’ll be surprised with how much you can solve by just carefully reading its contents."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Look It Up",
                        ImgUrl= "2021/12/icons8-google-shopping-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The next step is to look your error up. Basically you have to google it. When you’re hired you’ll be searching for stuff on your favourite search engine dozens of times a day. I still remember my first day on my first job, when a senior dev was helping me with some Javascript code and he searched for something on google. It was an eye-opener. Everyone does it. It doesn’t mean lack of knowledge, it just means humans aren’t robots that have everything accessible in a hard drive in their brains. Instead, the best developers know where to look. "
                            },
                            new Paragraph
                            {
                                Body = "For the first few years of your journey, rest assure that most of your questions will have been answered before. When you run into a problem without previous answers, chances are you didn’t ask the question correctly. The best way to do it is to copy and paste your error, verbatim. Except, of course, for the part that’s specific to your application. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Post Your Question",
                        ImgUrl= "2021/12/icons8-stack-overflow-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you google the problem using your own words or copying and pasting the error, you’ll quickly find out that most of these questions have been answered on stackoverflow.com."
                            },
                            new Paragraph
                            {
                                Body = "Even though you’ll find answers in different resources, this is the most reliable forum for programmers. You should create an account and if you can’t fix a certain problem, post your code and you’ll get help."
                            },
                            new Paragraph
                            {
                                Body = "Have a look at my account on stack overflow and you’ll see that I asked tons of questions throughout my journey. Most of these questions weren’t unique. They were problems that have already been solved but I couldn’t translate them into my code. With experience you’ll be able to adapt someone else’s answers to your code, but sometimes you’ll have to post your own for someone else to have a look."
                            },
                            new Paragraph
                            {
                                Body = "Remember. THERE IS A SOLUTION."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Ask Someone",
                        ImgUrl= "2021/12/icons8-apologise-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "More likely than not, you’ve already solved your problem by now, but if even Stackoverflow didn’t do it, you might need to ask someone. It could be a friend that has experience in the stack you’re training, or someone in our community, or myself. I ask questions every day at work, either to the senior devs, to the QA people, to my boss, or even junior devs that have more specific domain experience. "
                            },
                            new Paragraph
                            {
                                Body = "For asking questions directly, I recommend that first you verbalise it really well. Just by doing that you might come up with the solution. And also you save the person’s time because it will be easier to understand. Also make sure you have really exhausted every possible avenue. In your first job, you’ll have problems if you ask questions that are easy to look up, so it’s better to incorporate good habits right now."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Have a Break",
                        ImgUrl= "2021/12/icons8-relax-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You have everything it takes. The grit, the will power, you never quit. Now sometimes that gets in the way of solving a problem. After hours trying to fix something, the best to do is probably to have a break. Going for a walk does wonders. Go to the gym, talk to someone, socialise, sleep. If you can’t do any of these things, ok, watch something on Youtube or Netflix, but generally try doing things that don’t involve a screen."
                            },
                            new Paragraph
                            {
                                Body = "Remember, looking at a problem for hours isn’t a waste of time. Your brain is piecing everything together. You’re getting familiar with the code. An unproductive day stuck with a problem is really a great opportunity for learning. You learned a thousand ways it doesn’t work. And then, all of the sudden, in the middle of a break, you might have that Eureka moment. Or when you get back into it, you’ll have a fresh brain and renewed perspective. Trust me, it works! "
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 7,
                Title = "Setting Up",
                IconUrl = "2021/12/icons8-project-setup-96-1.png",
                Description = "Learn how to set up your develop environment with .NET framework and Visual Studio so you can get ready to start coding.",
                Area = Area.StartHere,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        ImgUrl= "2021/12/c-logo-icon-28402-1-300x288.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "So you’ve decided to start your backend journey using C#. You should be excited! .NET is a vast, powerful framework with endless tools for developers. There will always be something to learn!"
                            },
                            new Paragraph
                            {
                                Body = "Now there’s a bit of preparation to do. But don’t worry, if you have a decent internet connection and a minimally functioning computer, you’ll start writing code in a few hours. You do need space in your computer. If you install the .NET environment and run out of space, your experience will be painful. In that case, free some space, upgrade your hard drive or invest in a new computer."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Editor",
                        ImgUrl= "2021/12/icons8-visual-studio-2019-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The first thing you’ll need is Visual Studio, which is the IDE used in most companies that use .NET C#. It’s totally possible to use other editors such as the super popular Visual Studio Code. I suggest you use Visual Studio because it’s specially designed to work with .NET, but it’s totally up to you. "
                            },
                            new Paragraph
                            {
                                Body = "However, you’ll need to watch many tutorials online to close your knowledge gaps and most of them use Visual Studio. Dealing with the project structure in .NET can be a bit confusing in the beginning, so having juggle different editors can add to the confusion. With some experience you’ll be able to use Visual Studio Code or other editors if you really want to. "
                            },
                            new Paragraph
                            {
                                Body = "On the other hand, a good reason to use Visual Studio Code instead would be if you have a computer that’s too slow or doesn’t have too much space. Visual Studio Code is way lighter and needs less memory to run."
                            }
                        }
                    },
                    new Block
                    {
                        Title = ".NET Environment",
                        ImgUrl= "2021/12/icons8-visual-studio-2019-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "To get started, let’s install our IDE. When installing Visual Studio, you’ll also install the .NET Standard Developer Kit. If you’re confused about things like SDK, runtime, .NET framework, etc, you’re not alone. Here’s a Stack Overflow question where some of these terms and tools are (somewhat) explained."
                            },
                            new Paragraph
                            {
                                Body = "Visual Studio for Windows looks completely different from the Mac version. Make sure you follow a specific tutorial for the machine you’re using. If your machine is too slow, I highly recommend you use Visual Studio Code."
                            },
                            new Paragraph
                            {
                                Body = "If you opt for Visual Studio, go for the 2022 version on Windows and the 2019 version on Mac, since the 2022 for Mac is only a preview (as of August 2022).  Below are links to resources to install VS and VSC on all machines."
                            },
                            new Paragraph
                            {
                                Body = "Visual Studio for Windows\r\n\r\nVisual Studio for Mac\r\n\r\nVisual Studio Code for Windows\r\n\r\nVisual Studio Code for Mac\r\n\r\nVisual Studio Code for Linux"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl= "2021/12/icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Ok, almost good to go. Now you need a source control system. This is where you’ll back up your work and share it with other people. It’s an absolute must for developers and I recommend you start looking into it straight away. The most common source control system is Git. One of the tools invented by the genius Linus Torvalds, the creator of Linux. The most common platform is Github. Here a quick tutorial on how to create a Github account."
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            },
                            new Paragraph
                            {
                                Body = "To use all the functionalities of git you should learn to use it from the command line. But for now it will be enough if you can integrate it with Visual Studio. There are many other options better visualization and management of your repositories such as Github Desktop and Sourcetree. They’re very good tools with the main purpose of dealing with Git, but for a beginner, Visual Studio 2022’s Github integration will do just fine. "
                            },
                            new Paragraph
                            {
                                Body = "But remember, professional developers need to know git from the command line. User interface tools will help but not replace the CLI. As you get comfortable with Git, create a list of commands so you’re not dependent on anyone tool."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Taking Notes",
                        ImgUrl= "2021/12/icons8-google-docs-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The last thing you need is a decent note-taking system. You don’t need to go crazy on your notes. It might slow you down too much. I recommend you use it to optimise your time. Write lists of steps of the things you do repeatedly. Create notes with commands you keep forgetting. Create checklists for tasks that demand them. "
                            },
                            new Paragraph
                            {
                                Body = "There’s an infinite amount of note taking tools out there. You could use a physical notebook. If you’re an Apple user, “Notes” app is running on ICloud, which means your computer’s notes are integrated with your phone and Ipad. The system I recommend is Google Docs. It’s free, it has plenty of space for thousands of notes, the interface is very friendly and easy to organise/visualise and you can easily share your documents or work with someone else in the same document."
                            },
                            new Paragraph
                            {
                                Body = "If you want to go fancy, try Evernote or the one I use on a daily basis: Roamresearch.com. It’s paid but it’s the best I’ve seen so far. Whatever you do, keep your notes simple and organised. Back them up and protect them with your life. "
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 8,
                Title = "C# Foundations",
                IconUrl = "2021/12/icons8-sharp-94.png",
                Description = "Dive into basic C# syntax and control flow. You’ll learn just enough theory to have a solid foundation before jumping into our projects.",
                Area = Area.StartHere,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s time to start coding! Welcome to fantastic world of C#! If you haven’t yet, checkout the C# Setup article. You’ll need to set up your C# developer environment before starting."
                            },
                            new Paragraph
                            {
                                Body = "Now it’s time to learn the basic C# syntax. You need to be familiar with a few concepts and techniques before jumping into your first real project. The way you’ll attack this first contact with the language will depend on your learning style, but here’s my advice: Don’t try to understand EVERYTHING before starting to build."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "You don't need a lot to start building",
                        ImgUrl= "2021/12/icons8-builder-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "One of the biggest mistakes people make when starting to code is assuming they need to know A LOT before building interesting things. You’ll be surprised about what you can create with basic concepts you can learn within a few hours."
                            },
                            new Paragraph
                            {
                                Body = "By all means, make lots of notes when you’re first learning to code. Go through the entire material once or twice. But that’s it! The basic syntax hasn’t and won’t change significantly across the years. You’ll have to get back to the basics many times during your journey. Everything you initially have contact with will only be internalised with PRACTICE. So make sure you don’t spend more than a few hours learning the basic theory."
                            },
                            new Paragraph
                            {
                                Body = "Here’s an example of your self-talk when you start your first project: 'Oh, what do I need to do here? I think an if-else statement will be good to get the user input. How do I write it again? I remember I saw it in the documentation, but I’m not quite sure'. Then you’ll go back to your notes or the documentation, get what you need and apply in your code. You won’t know exactly how to do it, or even how it works yet, but you’ll know where to look and learn how it’s applied once you use it. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Video Course",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Here’s a video course by the C# Academy with the aim of providing the foundation you need for the upcoming projects. It differs from most beginners tutorials because we don’t just teach concepts that you have no idea how to apply in a real program. We will create a desktop game so that you see how each concept is applied in the context of a real world application."
                            },
                            new Paragraph
                            {
                                Body = "In the first part of the tutorial, we will build a console app where we’ll go over all the basics you need to get started. Starting with a console app is important because you can focus purely on C#. If you jump straight into Web, Desktop or Mobile Apps, there’s a lot of overhead code and setup that will distract you from actually learning what’s necessary at this stage. "
                            },
                            new Paragraph
                            {
                                Body = "But we understand that console apps aren’t very exciting. It’s nice to create something beautiful very early on,  so in the second part of the tutorial we will build the same app using the state-of-the-art .NET Maui, the latest, most exciting of .NET, the technology that allows us to build apps for Windows, Apple, Android and Mac using a single code base. "
                            },
                            new Paragraph
                            {
                                Body = "To get the most benefit from this tutorial, watch it along with following Microsoft’s Documentation as they complement each other. And I strongly suggest that once you’re finished, watch it again! You’ll be surprised about the amount of info you let slip in your first go. Plus you’ll retain much more if you watch it twice. "
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip"
                            },
                            new Paragraph
                            {
                                Body = "In the second part of the tutorial, you’ll again build a math game, but this time building a Desktop app, with the amazing .NET Maui. You can use the knowledge gained from this project to build an interface for all of your projects from now on. It can serve as a sandbox for you to practice your C# skills as opposed to the console."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Learning With Microsoft",
                        ImgUrl= "2021/12/icons8-bill-gates-100-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Even if you don’t love Bill Gates, you have to concede that Microsoft is great. Not only did they change the world forever with their products but they also created a programming language and will teach you how to use it! "
                            },

                            new Paragraph
                            {
                                Body = "Their documentation is very comprehensive and you can learn all of the basics just going through their beginners course. However be careful not to get lost. They offer so much material you could just use their academy forever. At this stage, stick to their Learn C# session. If you really need to, go through everything one more time, and that’s it! Time to jump into your first project."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Creating Your Library",
                        ImgUrl= "2021/12/icons8-books-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In the Setup article , you learned you have to create your source control repository. This will be your ultimate reference book. Every piece of code you ever write should be saved there. And guess what? That will also become your tool box. You’ll constantly grab pieces of code you’ve written before to reuse in your projects. "
                            },
                            new Paragraph
                            {
                                Body = "You can also use your note taking system for that. If you keep your notes and repository organised, you’ll feel like you’re building a nice library of code and saving time not having to rewrite everything from scratch. That will allow you to look for the next, more complex challenge, which will in turn become part of your library. Imagine where you’ll get after a few years doing this."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "More Videos",
                        ImgUrl= "2021/12/external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s great to learn from different sources. While we’re biased towards C# Academy’s beginner’s tutorial above, since it’s unique in that you learn concepts by applying them, we strongly encourage you to learn from different instructors throughout your journey. Here’s my favourite Beginners Tutorial. Mosh touches on everything you need to get started and after this video you can jump straight into the projects. Tim Corey is another excellent instructor to get started with."
                            },
                            new Paragraph
                            {
                                Body = "The most watched C# course on Youtube is excellent but it’s 4 hours long. It might take you weeks to watch it. I suggest you don’t go through the whole thing before jumping into projects. That’s exactly the type of behaviour that makes people quit. Initially stay away from super long, comprehensive tutorials, unless you break them in pieces and mix theory with practice. "
                            },
                            new Paragraph
                            {
                                Body = "Also, use Youtube to close knowledge gaps. If there’s something you don’t get during your journey, search for that specific topic and you’ll find tutorials just about that subject. The different teaching styles and approaches will help you understand that particular area you’re having trouble with."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "List of Basic Concepts",
                        ImgUrl= "2021/12/icons8-prepositions-next-to-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Just for reference, here’s a list of things you need to be familiar with before your first project:\r\n\r\n1. How to run a C# program\r\n\r\n2. Basic syntax\r\n\r\n3. Dealing with strings\r\n\r\n4. Data Types\r\n\r\n5. Variables\r\n\r\n6. Getting input from an user\r\n\r\n7. Basic maths operations\r\n\r\n8. C# helper methods\r\n\r\n9. How methods work\r\n\r\n10. Control-flow\r\n\r\n11. Arrays and Lists\r\n\r\n12. Loops"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 9,
                Title = "The Importance of Console Applications",
                IconUrl = "2021/12/icons8-baby-app-96.png",
                Description = "Building console applications will allow you to focus on the back end before diving into the complexities of front-end. Here’s why.",
                Area = Area.Console
            },
            new Article
            {
                Id = 10,
                Title = "Graduation!",
                IconUrl = "2021/12/icons8-baby-app-96.png",
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
                IconUrl = "2022/08/icons8-calculator-512.png",
                Description = "In your first project, you’ll create a calculator with the help of Microsoft's Documentation",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In your first project you’ll build a Console Calculator App with the help of Microsoft’s Documentation. If this is your first time building a project on your own, I suggest you first watch this series from our C# Foundation area, where we walk you through how to create a console app from scratch, while explaining important concepts in C#. If you have already watched it, or created applications before, this will be a breeze. But it’s still helpful to reinforce your knowledge. "
                    },
                    new Paragraph
                    {
                        Body="It will also serve as practice in a very important skill: following written documentation. This is something you’ll be doing on a regular basis as a professional developer, so it’s essential that you’re comfortable applying text-based instructions when developing software."
                    }
                },
                Requirements = new List<string>
                {
                    "Complete the following tutorial: Create a Calculator App (Microsoft Docs)"
                },
                RequirementsIntro = "This project has only one requirement:",
                Resources = new List<string>
                {
                    "Visual Studio for Mac",
                    "Visual Studio Code"
                },
                ResourcesIntro = "The instructions for this project are based on Visual Studio for Windows. The code you will write will be the same regardless of the code editor, but the process of creating a new project will differ. Here are links about how to create a console app with different editors: ",
                Tips = new List<string>
                {
                    "Don't forget to ALWAYS, I mean ALWAYS have your code saved on Github (or whatever source control you use). This way you won't lose your work, and you can always refer back to it in the future. You're building a library of your own!",
                    "Don't rush through the steps, even if this tutorial is easy for you. Make sure you understand EACH WORD of the code. Leave no stone unturned.",
                    "If there's anything you don't understand, hover over the code, and you'll get an explanation of what the term means. If you still can't understand it, google is your best friend. You'll find explanations about pretty much everything in forums like stackoveflow.com.",
                    "If this is your first project, I recommend doing it twice. You'll be surprised at how much your retention increases, and how many gaps were left in the first time.",
                    "Upon completion of your project, go to our Discord community and brag about it! It's a very important step to complete a project and you should celebrate."
                },
                 Challenges = new List<string>
                {
                    "Create a functionality that will count the amount of times the calculator was used.",
                    "Store a list with the latest calculations. And give the users the ability to delete that list.",
                    "Allow the users to use the results in the list above to perform new calculations.",
                    "Add extra calculations: Square Root, Taking the Power, 10x, Trigonometry functions.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl = "2021/12/icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If this is your first tutorial, you might be tempted to skip this step and start coding. Don’t do it or you’ll learn the hard way. One day after working for many hours on a difficult problem you won’t save your work on a source control repository and for whatever reason all of your work will be lost."
                            },
                            new Paragraph
                            {
                                Body = "Get into the habit of saving every line of code you ever write. I promise it will save you from many headaches. All serious developers save their work on a backup repository. The most commonly used is Github. Create an account if you haven’t yet. "
                            },
                            new Paragraph
                            {
                                Body="1. In Visual Studio, go to Git > Create Git Repository\r\n2. Enter your Login Details\r\n3. Click on Create and Push. "
                            },
                            new Paragraph
                            {
                                Body="✅ Done! Your repository is good to go. Don’t forget to commit and push your changes after every step!"
                            }, new Paragraph
                            {
                                Body="You can take further step and learn how to integrate Github with Visual Studio watching this tutorial:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Review",
                        ImgUrl= "2022/10/icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository,  follow this article, where you’ll learn how to create a fork from our base review repository."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Creating a Desktop App",
                        ImgUrl = "2022/08/icons8-desktop-computer-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the entire C# Foundation course, you have already created a Math Game Desktop app using the amazing .NET MAUI. It will be great practice to build a desktop Calculator App with the same functionality you’ve created for this console app. There will be some challenges, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on Discord and we will help!"
                            }
                        }
                    }
                }

            },
            new Project
            {
                Id = 2,
                Title = "Habit Logger",
                IconUrl = "2021/12/icons8-calendar-plus-96.png",
                Description = "Build a logger for a habit of choice. Learn how to interact with a database using SQLite and to get and validate user input",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This is a very simple app that will teach you how to perform CRUD operations against a real database. These operations are the base of web-development and you’ll be using them throughout your career in any most applications. We think it’s very important to do it from the start of your journey, since everything that will happen from here is just adding complexity to CRUD operations. No matter how complex and fancy the app you’re building is, in the end it all comes down to executing CRUD calls to a database."
                    },
                    new Paragraph
                    {
                        Body="For that you’ll have to learn very simple SQL commands. I know it sounds scary, but you’ll be amazed about how little SQL knowledge you need to build a full-stack app. Don’t worry, we will take you by the hand and by the end you’ll have completed your first fully functioning CRUD app. The most common ways of calling a SQL database with C# are through ADO.NET, Dapper and Entity Framework. We will start by using ADO.NET, because it’s the closest to raw SQL."
                    },
                    new Paragraph
                    {
                        Body="If you think this project is too hard for you and you have no idea where to even start, you’re probably right. You might need an extra hand to build a real application on your own. If that’s the case, watch the video tutorial for this project and then come back and try it again on your own. It’s perfectly ok to feel lost, since most beginner courses don’t actually teach you how to build something. "
                    },
                    new Paragraph
                    {
                        Body="So let’s go!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you’ll register one habit.",
                    "This habit can't be tracked by time (ex. hours of sleep), only by quantity (ex. number of water glasses a day)",
                    "The application should store and retrieve data from a real database",
                    "When the application starts, it should create a sqlite database, if one isn’t present.",
                    "It should also create a table in the database, where the habit will be logged.",
                    "The app should show the user a menu of options.",
                    "The users should be able to insert, delete, update and view their logged habit.",
                    "You should handle all possible errors so that the application never crashes.",
                    "The application should only be terminated when the user inserts 0.",
                    "You can only interact with the database using raw SQL. You can’t use mappers such as Entity Framework.",
                    "Your project needs to contain a Read Me file where you'll explain how your app works. Here's a nice example:",

                },
                RequirementsConclusion = "Github project with an example of a tidy Read Me file.\r\n\r\nDon't panic! I'll help! 😁",

                Tips = new List<string>
                {
                    "Test your SQL commands on DB Browser before using them in your program.",
                    "You can keep all of the code in one single class if you wish.",
                    "Use a switch statement for the user input menus.",
                    "Don't forget the user input's validation: Check for incorrect dates. What happens if a menu option is chosen that's not available? What happens if the users input a string instead of a number?"
                },
                 Challenges = new List<string>
                {
                    "Let the users create their own habits to track. That will require that you let them choose the unit of measurement of each habit.",
                    "Create a report functionality where the users can view specific information (i.e. how many times the user ran in a year? how many kms?) SQL allows you to ask very interesting things from your database."
                },
                 LearningIntro = "If you have learned the basics of C# following the C# Foundations article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
                 LearningItems = new List<string>
                 {
                     "Taking user input from the console.",
                     "Printing messages on the console. ",
                     "Installing nuget packages (ASP.NET libraries that will help you write your program).",
                     "Basic control flow with 'if-else' and 'switch statements'",
                     "Connecting to a Sqlite database.",
                     "Basics of SQL(the language you use to communicate with the database). If you want to train some SQL before getting started, here’s an excellent place."
                 },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Creating The Project",
                        ImgUrl= "2021/12/icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This tutorial requires that you already have set up your .NET environment. If you haven’t yet, check this article out with the first steps. If you absolutely want to use another IDE, let me know."
                            },
                            new Paragraph
                            {
                                Body = "1. In Visual Studio, choose Create new project. If you’re using Visual Studio Code, let me know if you have difficulties creating the project.\r\n2. Search for Console Application and click Next.\r\n3. Choose a Project Name and a Location and click Next.\r\n3. Choose the latest framework (Net 6 at the time of this tutorial) and click Create.\r\n4. Run your application by clicking on the green play button on the top of the screen."
                            },
                            new Paragraph
                            {
                                Body = "A CLI (command line interface) will open and print ‘Hello World’ and the application will close itself. That means your application ASP.NET environment and your application are working properly."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Changing Your Working Directory",
                        ImgUrl = "2021/12/icons8-folder-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This way .NET will build your project in your main folder. By default it builds your project in a bin folder and just to keep things simple we want to avoid that. That will create a Properties folder with a launchsettings.json file containing your configuration information. This is an important step only for applications that use Sqlite because you want the database to be created in the same folder of the application to avoid confusion."
                            },
                            new Paragraph
                            {
                                Body = "For that, click on the chevron next to the name of your app on the top menu, click on {nameoftheapp} Debug Properties and copy the path of your directory to the “Working Directory” field. To find out what your path is, you can right click on your project in the Solution Explorer and on “Copy Full Path” or look it up in your Files Explorer. If you’re using Mac/Visual Studio Code, reach out and I’ll tell you how to do it. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "2022/08/MicrosoftTeams-image-1.png"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "2022/08/MicrosoftTeams-image-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Start Coding!",
                        ImgUrl = "2021/12/icons8-coding-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Every time you start your app, it should check if there’s a database. If there isn’t, it will create one along with a table where you’ll store your data. If you delete your database externally, it will always create one. If the database exists, it will move to the next step: take the user input about what you want to do. Something like this:"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "2021/11/Screen-Shot-2021-11-26-at-8.29.52-pm-300x198.png"
                            },
                            new Paragraph
                            {
                                Body = "In ASP.NET C# development, the use of SQL Server is very common. But we won’t be using it here. SQLite is a super lightweight database system and it’s important to get familiar with it before jumping into SQL server."
                            },
                            new Paragraph
                            {
                                Body = "You’ll need to tell your program to create a sqlite file. You’ll be able to visualise that file externally with the help of a small application. Here’s a link with a basic sqlite tutorial."
                            },
                            new Paragraph
                            {
                                Body = "That’s where your actual code begins! You’re on your own for a while. If you get stuck, keep trying, remember the steps to debug your app. And if you ultimately can’t do it, reach out to our Discord community or myself and we will help!"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Next Step: Desktop App",
                        ImgUrl = "2022/04/icons8-staircase-80.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the entire C# Foundation course, you have already created a Math Game Desktop app using the amazing .NET MAUI. It will be great practice to build a desktop Habit Tracker App with the same functionality you’ve created for this console app. There will be some challenges, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on Discord and we will help!"
                            }
                        }
                    },
                }
            },
            new Project
            {
                Id = 3,
                Title = "Coding Tracker",
                IconUrl = "2021/12/icons8-smart-watch-96.png",
                Description = "Track your coding hours. Learn how to deal with dates, to use separation of concerns and use your first external library to enhance your application",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This app should be very similar to the Habit Tracker you’ve previously completed. It will serve the purpose of reinforcing what you’ve learned with a bit of repetition and building on that knowledge with slightly more challenging requirements. "
                    },
                    new Paragraph
                    {
                        Body="This time you’ll have to deal with the complexity of handling Dates and Times, which is a real challenge in any application. You’ll also be using your first external library. Often times in professional environments programmers don’t reinvent the wheel and save time by using public solutions provided by other coders. That’s the beauty of the internet. You have access to an amazing coding community! "
                    },
                    new Paragraph
                    {
                        Body="In the first app we also didn’t have requirements for coding organization. This time you’ll have to use separation of concerns, one of the most important principles in modern programming. This is where you’ll start applying concepts of Object Oriented Programming. You’ll also need to use a “Model”  or “Entity”, to to represent the data you are dealing with. In this case, your coding sessions. So let’s get started!"
                    }
                },
                Requirements = new List<string>
                {
                    "This application has the same requirements as the previous project, except that now you'll be logging your daily coding time.",
                    "To show the data on the console, you should use the \"ConsoleTableExt\" library.",
                    "You're required to have separate classes in different files (ex. UserInput.cs, Validation.cs, CodingController.cs)",
                    "You should tell the user the specific format you want the date and time to be logged and not allow any other format.",
                    "You'll need to create a configuration file that you'll contain your database path and connection strings.",
                    "You'll need to create a \"CodingSession\" class in a separate file. It will contain the properties of your coding session: Id, StartTime, EndTime, Duration",
                    "The user shouldn't input the duration of the session. It should be calculated based on the Start and End times, in a separate \"CalculateDuration\" method.",
                    "The user should be able to input the start and end times manually.",
                    "When reading from the database, you can't use an anonymous object, you have to read your table into a List of Coding Sessions."
                },
                Resources = new List<string>
                {
                    "Installing ConsoleTableExt using Nugget Packages.",
                    "Using a Configuration Manager.",
                    "Parsing DateTime in C#."
                },
                ResourcesIntro = "If you have learned the basics of C# following the C# Foundations article, and completed the Habit Tracker project, you should know all the basic techniques needed to complete this project. Here’s a list of extra resources you might need:",
                Tips = new List<string>
                {
                    "It's up to you the order in which you'll build, but we recommend you do it in this order: configuration file, model, database/table creation, CRUD controller (where the operations will happen), TableVisualisationEngine (where the consoleTableExt code will be run) and finally: validation of data.",
                    "Sqlite doesn't support dates. We recommend you store the datetime as a string in the database and then parse it using C#. You'll need to parse it to calculate the duration of your sessions.",
                    "Don't forget to push your changes to github every time you stop working.",
                    "Don't forget the user input's validation: Check for incorrect dates. What happens if a menu option is chosen that's not available? What happens if the users input a string instead of a number? Remember that the end date can't be before the start date."
                },
                 Challenges = new List<string>
                {
                    "Add the possibility of tracking the coding time via a stopwatch so the user can track the session as it happens.",
                    "Let the users filter their coding records per period (weeks, days, years) and/or order ascending or descending.",
                    "Create reports where the users can see their total and average coding session per period.",
                    "Create the ability to set coding goals and show how far the users are from reaching their goal, along with how many hours a day they would have to code to reach their goal. You can do it via SQL queries or with C#.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Creating a Configuration File",
                        ImgUrl = "2022/01/external-configuration-computer-itim2101-lineal-color-itim2101-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In advanced applications, configuration properties are stored in an xml file. This practice makes it easier to configure your application in production. It’s not absolutely necessary now, but it’s not hard to learn and you should get used to it from the beginning of your coding journey. It makes your code cleaner and more organised. Check out the documentation and if necessary search for “configuration file C#” on Youtube. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Creating a Desktop App",
                        ImgUrl = "2022/08/icons8-desktop-computer-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the entire C# Foundation course, you have already created a Math Game Desktop app using the amazing .NET MAUI. It will be great practice to build a desktop Coding Tracker App with the same functionality you’ve created for this console app. There will be some challenges, especially if you want to create a timer, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on Discord and we will help!"
                            }
                        }
                    }
                }
            },
            new Project
            {
                Id = 4,
                Title = "Flashcards",
                IconUrl = "2021/12/icons8-quizlet-96.png",
                Description = "Building stacks of flashcards and a study functionality. Learn to deal with linked databases using SQL Server and to use Data Transfer Objects",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="After the first two projects, you should be somewhat comfortable with how things work in C#. It’s time to make things slightly more complex. You’ll be using SQL Server for the first time. We could continue using SQLite, as it does everything needed for most small applications, but SQL Server is heavily used in the industry and the sooner we get familiar with it, the better."
                    },
                    new Paragraph
                    {
                        Body="This time the database will be a little more complex as well. We will have two tables linked by a foreign key. And for the first time we will be working with DTOs (Data Transfer Objects), which will help us use the same object in different ways."
                    },
                    new Paragraph
                    {
                        Body="Time to get started!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where the users will create Stacks of Flashcards.",
                    "You'll need two different tables for stacks and flashcards. The tables should be linked by a foreign key.",
                    "Stacks should have an unique name.",
                    "Every flashcard needs to be part of a stack. If a stack is deleted, the same should happen with the flashcard.",
                    "You should use DTOs to show the flashcards to the user without the Id of the stack it belongs to.",
                    "When showing a stack to the user, the flashcard Ids should always start with 1 without gaps between them. If you have 10 cards and number 5 is deleted, the table should show Ids from 1 to 9.",
                    "After creating the flashcards functionalities, create a \"Study Session\" area, where the users will study the stacks. All study sessions should be stored, with date and score.",
                    "The study and stack tables should be linked. If a stack is deleted, it's study sessions should be deleted.",
                    "The project should contain a call to the study table so the users can see all their study sessions. This table receives insert calls upon each study session, but there shouldn't be update and delete calls to it."
                },
                Tips = new List<string>
                {
                    "Before starting to code, try creating tables and running a few CRUD queries in SQL Server to get familiar with SQL Server Studio.",
                    "For management of stacks, let the user choose the stack by name.",
                    "Think of the \"stacks\" and \"study\" areas almost as separate applications. The study area is merely using data from the stacks area."
                },
                Challenges = new List<string>
                {
                    "Add the possibility of tracking the coding time via a stopwatch so the user can track the session as it happens.",
                    "Let the users filter their coding records per period (weeks, days, years) and/or order ascending or descending.",
                    "Create reports where the users can see their total and average coding session per period.",
                    "Create the ability to set coding goals and show how far the users are from reaching their goal, along with how many hours a day they would have to code to reach their goal. You can do it via SQL queries or with C#.",
                },
                LearningIntro = "If you have learned the basics of C# following the C# Foundations article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
                LearningItems = new List<string>
                 {
                     "Using SQL Server.",
                     "Creating linked tables with SQL.",
                     "Using DTOs to create different versions of classes.",
                     "Pivoting Tables in SQL."
                 },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Installing SQL Server",
                        ImgUrl = "2022/01/icons8-sql-server-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "\r\nInstalling SQL Server\r\nThis is the first project in the academy where we’ll be using SQL Server. You can work with SQL Server using Visual Studio. But I recommend you start using Microsoft SQL Server Management Studio. For this app, don’t use SQL Server EXPRESS, but only LOCAL DB. Here’s a tutorial on how to install the studio. And here’s a tutorial on how to connect to your localdb using the studio.  "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Challenge",
                        ImgUrl = "2022/04/icons8-courage-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want to expand on this project, here’s an idea. Try to create a report system where you can see the number of sessions per month per stack. And another one with the average score per month per stack. This is not an easy challenge if you’re just getting started with databases, but it will teach you all the power of SQL and the possibilities it gives you to ask interesting questions from your tables."
                            },
                            new Paragraph
                            {
                                Body = "Below’s a screenshot with an example of the finished report. You’ll need to learn about Pivoting Tables to complete this challenge. Reach out if you need help! "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "2022/04/Screen-Shot-2022-04-04-at-6.49.23-am-1-1024x305.png"
                            }
                        }
                    }
                }
            },
            new Project
            {
                Id = 5,
                Title = "Drinks Info",
                IconUrl = "2022/02/89-897207_alcohol-alcoholic-bar-cafe-cocktail-mixed-drink-party-drinks-clipart-png.png",
                Description = "Build a console app to consume an external API with HTTP Requests with C#",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Often times developers work with third-party data. A very common way of accessing external vendor’s data is to make requests to their APIs (Application Programming Interface). Once we have access to their data, we can process in our application to suit our needs. Another common scenario is when an organisation has multiple independent applications that communicate amongst themselves. The so-called microservices."
                    },
                    new Paragraph
                    {
                        Body="In this application we will learn how to connect to an external API through HTTP requests using .NET’s class library. It‘s easier than you imagine! Luckily there are many public APIs out there. Here’s a great list of public APIs for practice."
                    }
                },
                Requirements = new List<string>
                {
                    "You were hired by restaurant to create a solution for their drinks menu.",
                    "Their drinks menu is provided by an external company. All the data about the drinks is in the companies database, accessible through an API.",
                    "Your job is to create a system that allows the restaurant employee to pull data from any drink in the database.",
                    "You don't need SQL here, as you won't be operating the database. All you need is to create an user-friendly way to present the data to the users (the restaurant employees)",
                    "When the users open the application, they should be presented with the Drinks Category Menu and invited to choose a category. Then they'll have the chance to choose a drink and see information about it.",
                    "When the users visualise the drink detail, there shouldn't be any properties with empty values"
                },
                RequirementsConclusion = "Don't panic! We'll help! 😁", 
                ResourcesIntro = "Here are the links for using HTTP calls with C# and to the Drinks API documentation:",
                Resources = new List<string>
                {
                    "Cocktail Database",
                    "Microsoft Docs: HTTP Requests"
                }
            },
            new Project
            {
                Id = 6,
                Title = "Phone Book",
                IconUrl = "2022/05/icons8-contact-book-512-150x150.png",
                Description = "Now you have basic understanding of SQL, it’s time to learn the basics of Entity Framework with a CRUD Phone Book Console App",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In the .NET ecosystem you’ll come across ORMs (Object-Relational Mapping), which helps you to deal with databases using objects. If you have searched for C# tutorials you’ve probably encountered technologies such as Dapper and Entity Framework. You’ll definitely be using one when you start working as a developer."
                    },
                    new Paragraph
                    {
                        Body="In this tutorial we’ll implement a very simple Phone Book so you can learn the basics of Entity Framework, the most popular ORM. Even though we at The C# Academy strongly believe C# students should learn raw SQL first and foremost, most .NET C# job applications demand Entity Framework. The good news is that EF’s basic operations are very simple to learn and you’ll be up and running very quickly. Let’s go!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record contacts with their phone numbers.",
                    "Users should be able to Add, Delete, Update and Read from a database, using the console.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "Your code should contain a base Contact class with {Id INT, Name STRING and Phone Number(STRING)}",
                    "You should use Code-First Approach, which means EF will create the database for you.",
                    "You should use SQL Server, not SQLite"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "Entity Framework Docs",
                    "CRUD Console APP with EF on Youtube"
                },
                ResourcesConclusion = "There are many other Youtube videos and blog articles about Entity Framework everything else you need. Don’t be ashamed to use Google!",
                Tips = new List<string>
                {
                    "Before starting the phone book app, finish the program in the Microsoft Documentation article without any changes and store in your Github repository for reference. Make sure you understand most of the code before you get started.",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "As a challenge, create a functionality that allows users to add the contact's e-mail address and send an e-mail message from the app."
                },
                Challenges = new List<string>
                {
                    "Create a functionality that allows users to add the contact's e-mail address and send an e-mail message from the app.",
                    "Expand the app by creating categories of contacts (i.e. Family, Friends, Work, etc).",
                    "What if you want to send not only e-mails but SMS?"
                }
            },
            new Project
            {
                Id = 7,
                Title = "Shifts Logger",
                IconUrl = "2022/05/icons8-nurse-256.png",
                Description = "Build an App for shift workers to log their hours. In this app you’ll learn how to build a Web API and consume it with a Console App",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="If you’ve been learning to code for more than five minutes, you probably heard about “APIs“. They’re at the core of back-end programming. In web development, their main job will be to communicate with databases using “endpoints”. From now on you’ll be creating APIs all the time and this acronym will forever be part of your vocabulary. "
                    },
                    new Paragraph
                    {
                        Body="In the Drinks Info App we have created a program that consumed an external API. This time we will track a worker’s “shifts”. We’ll create an API and the console app that will consume it. When using Microsoft’s Documentation, often times you’ll come across Web APIs being developed with Entity Framework, which acts as layer between the “endpoints” and the actual database. "
                    },
                    new Paragraph
                    {
                        Body="This stack (Web API/EF) is very common in enterprise applications, but it’s important to know that  Web Apis can be developed using ADO.NET and Dapper. These data access solutions have the advantage of giving the developers more control over the SQL queries. In the end, all solutions are valid. Each has pros and cons and it comes down to personal preference. For this project, we will be using Entity Framework, as it takes care the basic CRUD operations we need as beginners. "
                    },
                    new Paragraph
                    {
                        Body="This project has as a requirement the use of Web APIs testing tools. In development you need a way to quickly test your endpoints without having to create a UI. These days, Swagger is already scaffolded into the .NET Core Web Api project so you can start using it as soon as you run your project. Postman is very complete external tool with an user interface that makes it very easy to store tests for later use, which saves a lot of development time. The learning curve for Postman is slightly steeper, but don’t skip it, it will pay off. "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record a worker's shifts.",
                    "You need to create two applications: the Web API and the UI that will call it.",
                    "All validation and user input should happen in the UI app.",
                    "Your API's controller should be lean. Any logic should be handled in a separate \"service\".",
                    "You should use SQL Server, not SQLite",
                    "You should use the \"code first\" approach to create your database, using Entity Framework's migrations tool."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "What are APIs?",
                    "Web API Docs",
                    "Testing Web APIs with Swagger.",
                    "Postman Youtube Tutorial"

                },             
                Tips = new List<string>
                {
                    "If this is your first contact with .NET Web API, follow the tutorial closely using the Todo List data model and http-repl for testing. In a second moment, follow the tutorial one more time, this time following the project's requirements.",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "First, create the Web API project, then use Swagger and Postman to test it. Only then create the UI project.",
                    "You might be tempted to skip testing with Swagger and Postman. Don't make that mistake. These tools are essential for working with web apis in enterprise and your hiring managers will be unimpressed if you are not familiar with them.",
                    "Calculate the duration of the shift based on its start and end.",
                }
            },
            new Project
            {
                Id = 8,
                Title = "Exercise Tracker",
                IconUrl = "2022/02/icons8-bench-press-96.png",
                Description = "Learn the repository pattern, the most common design pattern for interaction with databases",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="So far we have been developing our applications without thinking too much about their design. In software development, we’ll often use “general repeatable solutions to commonly occurring problems”,  the so called design patterns."
                    },
                    new Paragraph
                    {
                        Body="We will build an exercise tracker using the “Repository Pattern”, an almost universally used solution for data persistence. It creates a layer between business logic and data access, which helps us create more loosely-coupled, testable and maintainable applications. You’ll be dealing with repositories on a daily-basis when you get your C# job!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record exercise data.",
                    "You should choose one type of exercise only. We want to keep the app simple so you focus on the subject you're learning and not on the business complexities.",
                    "You can choose raw SQL or Entity Framework for your data-persistence.",
                    "The model for your exercise class should have at least the following properties: {Id INT, DateStart DateTime, DateEnd DateTime, Duration TimeSpan, Comments string}",
                    "Your application should have the following classes: UserInput, ExerciseController, ExerciseService (where business logic will be handled) and ExerciseRepository.",
                    "You can choose between SQLite or SQLServer.",
                    "You need to use dependency injection to access the repository from the controller."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "Repository Patterns Docs",
                    "Repository Pattern Tutorial",
                    "Repository Pattern with EF on Youtube"
                },
                ResourcesConclusion = "There are many other Youtube videos and blog articles about the Repository Pattern. Google is your best friend!",
                Tips = new List<string>
                {
                    "Don't forget to add validation to your app. Besides the same validation you used in previous apps, you'll also need to make sure users only add phone-numbers with the correct format (specified by you).",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "You might come across the concept of Unit of Work in some tutorials. I suggest you don't use it, so you focus on learning how a single repository works.",
                    "Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern.",
                    "If you want to expand on your knowledge so far, create an application with two types of exercises (ex. weights and cardio), using EF for one and Raw SQL for the other."
                },
                Challenges = new List<string>
                {
                    "To illustrate the separation provided by the repository pattern, create a different branch of your project where you'll replace Entity Framework by Dapper or ADO.NET in your repository. You'll notice that you won't need to touch your controller.",
                    "Create an application with two types of exercises (ex. weights and cardio), using EF for one and Raw SQL for the other"
                }
            },
            new Project
            {
                Id = 9,
                Title = "Sports Results Notifier",
                IconUrl = "2022/02/icons8-sports-96.png",
                Description = "Learn how to create a web crawler and send e-mails using C#",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="You’re getting close to the end of our beginner C# program. But before your graduation from this first phase you need to learn two very important tasks in programming: The ability to harvest data from non-api sources and the ability to send e-mails. Let’s create an application that will combine these two tasks."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should read sports data from a website once a day and send it to a specific e-mail address.",
                    "You don't need any interaction with the program. It will be a service that runs automatically.",
                    "The data should be collected from the Basketball Reference Website in the resources area.",
                    "You should use the Agility Pack library for scrapping."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "Agility Pack Docs",
                    "Send An Email Using Gmail SMTP and C#",
                    "Agility Pack Tutorial",
                    "Basketball Reference"
                },
                ResourcesConclusion = "There are many other Youtube videos and blog articles about scrapping and sending an e-mail with C#. Google is your best friend! 🙂",
                Tips = new List<string>
                {
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "After the completion of this project, try to create your own scrapper from a different source and with a different business case.",
                    "Bear in mind that some websites don't authorise scrapping.",
                    "Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern.",
                    "It's not simple to scrap data from websites generated dynamically with the help of Javascript frameworks. When you create your own project, be aware that it's easier to scrape from more traditional, simple, server-based ones."
                }
            },
            new Project
            {
                Id = 10,
                Title = "Excel Reader",
                IconUrl = "2022/02/Excel-icon-removebg-preview.png",
                Description = "Learn how to read data from an Excel Sheet into a real database using SQL",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now  that you have an initial foundation of C#, it’s time to tackle a very important task in programming. The ability to work with files.When working in a company, all sorts of documents will be generated using a variety of file types: .doc, .xls, .pdf, .csv, just to name a few of the most commonly used. "
                    },
                    new Paragraph
                    {
                        Body="Your job as a programmer is to create applications that will manipulate data “to and from” these files. In this project, we will transpose an excel table into an SQL database using a C# library."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application that will read data from an Excel spreadsheet into a database",
                    "When the application starts, it should delete the database if it exists, create a new one, create all tables, read from Excel, seed into the database.",
                    "You need to use EPPlus package",
                    "You shouldn't read into Json first.",
                    "You can use SQLite or SQL Server (or MySQL if you're using a Mac)",
                    "Once the database is populated, you'll fetch data from it and show it in the console.",
                    "You don't need any user input",
                    "You should print messages to the console letting the user know what the app is doing at that moment (i.e. reading from excel; creating tables, etc)",
                    "The application will be written for a known table, you don't need to make it dynamic."
                },
                ResourcesIntro = "The knowledge you gained from the previous three projects will be enough to complete this project.\r\n\r\nYou’ll only need to find out how EPPlus Package works. Here’s a good Youtube Tutorial. If it’s not enough search for further videos on Youtube and/or specific questions in StackOverflow 😁",
                Tips = new List<string>
                {
                    "Before anything else you’ll have to create an Excel table that will be stored in your main project folder. The more organised the easier it will be for your program to read it. The first row of your columns need to be the property names of your model class",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "Remember, this time you don’t need any user input. The only interaction your program will have with the user is to show the data from your database.",
                    "You could structure the program in three parts. One for database creation, one for reading from the file and return a list and the last to populate your database using the returned list"
                },
                Challenges = new List<string>
                {
                    "If you want to expand on this project, try to create a program that reads data from any excel sheet, regardless of the number of columns or the content of the header.",
                    "Add the ability to read from other types of files, i.e. csv, pdf, doc",
                    "Let the user choose the file that will be read, by inserting the path.",
                    "Add a functionality to write into files, you can also use EPPlus for that."
                }
            },
            new Project
            {
                Id = 11,
                Title = "Unit Testing",
                IconUrl = "2022/02/icons8-test-tube-100.png",
                Description = "The last piece of the puzzle before moving on to  front-end. Learn to test the business logic of your applications",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="We’re almost there! It’s been a long way and it’s almost time to celebrate your graduation from the Console Apps area. But there’s one final step: Unit Tests."
                    },
                    new Paragraph
                    {
                        Body="More likely than not (and hopefully) the organisation you’ll work will have systems that use automatic unit testing. They make sure everything is running properly before each deployment. The code covered by those tests won’t need to be tested manually every time a change is made, which is prone to errors and very expensive. A strong suite of unit tests helps developers write better code, more efficiently. So let's do it!"
                    }
                },
                Requirements = new List<string>
                {
                    "In this project, you'll create unit tests for the Coding Tracker App, the second project in the course",
                    "You'll need to create a CodingTracker.Tests project, parallel to your coding tracker and reference it in your csproj file",
                    "You'll only test the validation methods, making sure the app correctly prevents the user from giving incorrect inputs",
                    "You should use .NETs MSTest Library",
                    "You should test both correct and incorrect inputs"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "The importance of unit testing",
                    "MSTest Docs",
                    "Unit Testing C# Code  on Youtube"
                },
                Tips = new List<string>
                {
                    "Don't worry about integration or end-to-end tests, they're out of the scope of this project",
                    "Make sure the names of your tests are clear, even if they have to be long. \"WhenQuantityInputIsCorrect()\" is a good name, while \"QuantityTest\" doesn't have enough information.",
                    "In your test, you'll have to mock the tested service and call it's methods. Think of all possibilities of correct and incorrect inputs and test if the application handles them."
                }
            },
            new Project
            {
                Id = 12,
                Title = "Portfolio",
                IconUrl = "2022/05/icons8-portfolio-512.png",
                Description = "Time to create a portfolio! Let’s present your work using a nice front-end technology of your choice",
                Area = Area.StartApplying
            },
            new Project
            {
                Id = 13,
                Title = "Resume",
                IconUrl = "2022/05/icons8-resume-512.png",
                Description = "The last step before start applying for jobs. Let’s build a nice resume before hit the Apply button",
                Area = Area.StartApplying
            },
            new Project
            {
                Id = 14,
                Title = "Water Drinking Logger",
                IconUrl = "2022/04/icons8-drinking-96.png",
                Description = "Build your first full-stack app with ASP.NET C# Razor Pages and ADO.NET",
                Area = Area.MVC
            },
            new Project
            {
                Id = 15,
                Title = "Movies",
                IconUrl = "2022/05/icons8-movie-512.png",
                Description = "Build your first full-stack app with ASP.NET C# MVC and Entity Framework",
                Area = Area.MVC
            },
            new Project
            {
                Id = 16,
                Title = "Todo List",
                IconUrl = "2022/03/external-checklist-vacation-planning-cycling-tour-flaticons-lineal-color-flat-icons-2.png",
                Description = "Build your first MVC application with C#, Razor Syntax, Javascript and Bootstrap",
                Area = Area.MVC
            },
            new Project
            {
                Id = 17,
                Title = "Budget",
                IconUrl = "2022/05/icons8-budget-512.png",
                Description = "Build a personal finance app with multiple related tables in the back-end",
                Area = Area.MVC
            },
            new Project
            {
                Id = 18,
                Title = "Authentication and Authorization",
                IconUrl = "2022/05/icons8-safe-ok-480.png",
                Description = "Learn how to secure your app with ASP.NET Core Identity",
                Area = Area.MVC
            },
            new Project
            {
                Id = 19,
                Title = "Ecommerce",
                IconUrl = "2022/05/icons8-online-store-64.png",
                Description = "Build a fully functioning ecommerce for products of your choice",
                Area = Area.MVC
            },
            new Project
            {
                Id = 20,
                Title = "E-Commerce Admin",
                IconUrl = "2022/05/icons8-admin-512.png",
                Description = "Build an administration page for the e-commerce you build in project 6, using Asp.NET Role-based Authentication",
                Area = Area.MVC
            },
            new Project
            {
                Id = 21,
                Title = "Tour of Heroes",
                IconUrl = "2022/06/icons8-superwoman-480.png",
                Description = "Learn the basics of Angular by building a purely front-end app using the documentation",
                Area = Area.Angular
            },
            new Project
            {
                Id = 22,
                Title = "Coffee Tracker",
                IconUrl = "2022/05/icons8-coffee-mug-128.png",
                Description = "Track your coffee consumption with a C# Web Api and Angular",
                Area = Area.Angular
            },
            new Project
            {
                Id = 23,
                Title = "Sleep Tracker",
                IconUrl = "2022/05/icons8-sleeping-512.png",
                Description = "Build on your Angular foundation with an app to log and generate reports about your sleep",
                Area = Area.Angular
            },
            new Project
            {
                Id = 24,
                Title = "Quiz Game",
                IconUrl = "2022/05/icons8-quiz-game-contestants-480.png",
                Description = "Build a highly interactive Quiz Game with Angular and Angular Material",
                Area = Area.Angular
            },
            new Project
            {
                Id = 25,
                Title = "Tic-Tac-Toe",
                IconUrl = "2022/07/icons8-tic-tak-toe-cross-and-circle-matrix-game-with-work-strategy-concept-384.png",
                Description = "A very simple project to easy you into with this rich framework. You’ll be consuming an Api of your choice",
                Area = Area.React
            },
            new Project
            {
                Id = 26,
                Title = "Call an External API",
                IconUrl = "2021/12/icons8-baby-app-96.png",
                Description = "Build a simple Get Endpoint with .NET and fetch data from it using React",
                Area = Area.React
            },
            new Project
            {
                Id = 27,
                Title = "Shopping List",
                IconUrl = "2022/07/icons8-shopping-list-512.png",
                Description = "Build your first full CRUD app with React, calling a .NET Web API",
                Area = Area.React
            },
            new Project
            {
                Id = 28,
                Title = "Friends Manager",
                IconUrl = "2022/06/icons8-friend-512.png",
                Description = "Build an app that will help you monitor and cultivate your friendships managing state with Redux",
                Area = Area.React
            },
            new Project
            {
                Id = 29,
                Title = "Wardrobe Inventory",
                IconUrl = "2022/06/icons8-wardrobe-392.png",
                Description = "Get started with Blazor by building an inventory for your clothes. With pictures!",
                Area = Area.Blazor
            },
            new Project
            {
                Id = 30,
                Title = "Memory Game",
                IconUrl = "2022/06/icons8-memory-512.png",
                Description = "Build a simple memory game where users will train their brain and track results",
                Area = Area.Blazor
            },
            new Project
            {
                Id = 31,
                Title = "Food Journal",
                IconUrl = "2022/06/icons8-ingredients-480.png",
                Description = "Log your food habits in your first CRUD Blazor App",
                Area = Area.Blazor
            },
            new Project
            {
                Id = 32,
                Title = "Sports Statistics",
                IconUrl = "2022/06/icons8-football-team-480.png",
                Description = "Build an application to track the performance of a sports team in real time",
                Area = Area.Blazor
            },
            new Project
            {
                Id = 33,
                Title = "Math Game",
                IconUrl = "2022/08/icons8-maths-376.png",
                Description = "Start your native app development journey building a simple game with the four basic mathematical operations",
                Area = Area.MAUI
            },
            new Project
            {
                Id = 34,
                Title = "Books to Read",
                IconUrl = "2022/08/icons8-bookshelf-512.png",
                Description = "Build an app to keep track of reading activity using the MVVM pattern",
                Area = Area.MAUI
            },
            new Project
            {
                Id = 35,
                Title = "Monkeys Data",
                IconUrl = "2022/08/icons8-see-no-evil-monkey-256.png",
                Description = "Build an advanced Mobile UI to present data about Monkeys, using Geolocation to show which monkey is closest to you",
                Area = Area.MAUI
            },
            new Project
            {
                Id = 36,
                Title = "Warehouse Admin",
                IconUrl = "2022/08/icons8-warehouse-512.png",
                Description = "Track warehouse operations using a complex data model with Maui",
                Area = Area.MAUI
            },
            new Project
            {
                Id = 37,
                Title = "Deploying a Simple App",
                IconUrl = "2022/09/icons8-web-392.png",
                Description = "Start with Azure creating an account and deploying a simple app without a database",
                Area = Area.Azure
            },
            new Project
            {
                Id = 38,
                Title = "Deploying a full-stack .NET app",
                IconUrl = "2022/09/icons8-full-stack-512.png",
                Description = "Deploy a crud app from the .NET ecosystem along with a database server",
                Area = Area.Azure
            },
            new Project
            {
                Id = 39,
                Title = "Deploy a full-stack .NET + JS Framework app",
                IconUrl = "2022/09/icons8-website-468.png",
                Description = "Deploy a full-stack app using a JS framework along with a .NET Web API",
                Area = Area.Azure
            },
            new Project
            {
                Id = 40,
                Title = "Azure Functions",
                IconUrl = "2022/09/icons8-cloud-connection-480.png",
                Description = "Get started with serverless computing creating backend services directly on the cloud",
                Area = Area.Azure
            }
        };
    }
}
