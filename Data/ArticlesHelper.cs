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
                IconUrl = "icons8-baby-app-96.png",
                Description = "Learn to set up your developer environment and basic C# concepts to get you started.",
                Area = Area.HowItWorks

            },
            new Article
            {
                Id = 2,
                Title = "Learn by Doing",
                IconUrl = "icons8-direction-512.png",
                Description = "Dive into our projects, tailored to get you from absolute beginner to advanced, building your skills one step at a time.",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 3,
                Title = "Community Based",
                IconUrl = "icons8-ask-96.png",
                Description = "When you get stuck, reach out and we will help you figure out the solution, teaching you how to think like a professional developer. ",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 4,
                Title = "Get Job Ready",
                IconUrl = "icons8-submit-resume-80.png",
                Description = "With our help, create a resume, build a portfolio and start jobseeking.",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 5,
                Title = "Start Here",
                IconUrl = "icons8-door-80.png",
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
                        ImgUrl = "icons8-in-doubt-skin-type-3-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>We won’t teach you how to code</u></i></b>. We’ll teach you how to teach yourself and nudge you in the right direction. You have to do it yourself if you want to have any chance of succeeding in a real job. Even if you pay us a lot of money to be your full time code teacher, if you don’t learn how to learn on your own you don’t have a chance in this industry."
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
                        ImgUrl = "icons8-community-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Learning how to code, you’ll spend hour upon hour by yourself, in front of your computer, banging your head against the wall, solving problems. Chances are you’ll feel lonely and isolated at times. It makes a difference connecting with people that are going through the same. You’re not alone! We’re here to help. <a href='https://discord.gg/JVnwYdM79C'>Join us on Discord</a> and if the link isn’t working add me and send me a personal message at <b><i><u>pablocappuccino#4729</u></i></b>. No message will be left unanswered."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Clear Pathway",
                        ImgUrl = "icons8-ambition-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s very important to have <b><i><u>clear stepping stones</u></i></b> and benchmarks as references for your work. It’s easy to feel lost in the sea of information and possibilities the web gives us. You need to give your brain a rest by laying out a pathway that will be in the back of your mind throughout your journey. Decision fatigue is exhausting and frustrating. It can undermine your progress and ultimately lead to failure."
                            },
                            new Paragraph
                            {
                                Body = "At the C# Academy you can find a roadmap with all the steps necessary to become a full stack web developer. It’s not necessarily linear and the lines between the stages are blurry. You’ll be constantly revisiting the previous items on the checklist, at any given time during your progress. <a href='https://www.thecsharpacademy.com/2021/09/10/road-map/'>Here's the roadmap</a>."
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
                        ImgUrl = "icons8-feedback-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "As we progress through our road map, you’ll be building projects, a portfolio, a resume and preparing for interviews. We’ll give you feedback on all of those. Each of our projects have a list of requirements, but there are always details in the design, implementation and code style that are open to your own individuality. We encourage you try things on your own and we’ll only suggest corrections that are considered bad practice."
                            },
                            new Paragraph
                            {
                                Body = "We have a list of projects to get you started and new projects will be added constantly. If you want to know our view on what to build, <a href='https://cappuccinocoding.com/2021/09/15/what-projects-should-you-work-on/'>please check this blog post</a>. It will give you ideas to think of your own projects, and some perspective on what types of projects are effective for a portfolio."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Organisation",
                        ImgUrl = "icons8-tidy-shelf-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>You need to do some housekeeping before starting</u></i></b>.  I’m sure there are messy disorganised high achievers in this world. But in my experience, creating the right environment, organising your life and your priorities and removing the clutter (mental and physical) of your life will improve your chances of success. Here are some things to consider:"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Gear",
                        ImgUrl = "icons8-equipment-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>Get a good machine</u></i></b>. I started with an old 2014 Dell. I quickly realised I needed something better and bought a 128GB 2019 Mac. About a year later I realised having Windows made things way easier for .Net development and I bought a 500GB 2020 Mac to have more space for a virtual machine. Two years later a bought a powerful HP/Windows machine so I could use the full potential of Microsoft’s tools for .NET developers.  I’m not rich, I just worked hard and saved the money to buy it. It’s part of my “I’ll do whatever it takes” mentality."
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
                                PictureUrl = "IMG_8392-768x576.jpg"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Time",
                        ImgUrl = "icons8-timetable-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>You have to carve out time in your life if you want to learn how to code</u></i></b>. I admit it was easier for me because I worked from 11am so I would just wake up at 4am every day and code as much as I could."
                            },
                            new Paragraph
                            {
                                Body = "If you can do it first thing in the morning, it will be better. If you can’t, do it as soon as you can. If you leave it to bed time, while not impossible, it will be really hard to focus and absorb anything."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>You will have to say NO to requests for your time</u></i></b>. I sacrificed relationships because I wasn’t willing to give up my morning to spend time with them. My morning is sacred, it’s coding time and unless a family member was dying (which never happened), I would be coding. Protect your time."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>Also, track your time</u></i></b>. I’m a geek, so I track every hour of my day. You don’t need to go that far, but I suggest you track at least your coding hours. I always aimed for 28hs of programming per week. Even though I almost never achieved it, I never coded less than 20hs a week, in part due to the big goal. Start recording your results today and lay them out on a spreadsheet. Try to beat your daily, weekly and monthly records."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Notes",
                        ImgUrl = "icons8-timetable-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You need to take notes. Don’t worry about taking notes about theoretical things you’re learning, unless that’s how you comprehend things. Instead, take notes about the steps you’re taking to complete a project and about errors you encountered and how you solved them. You will need those in the feature. "
                            },
                            new Paragraph
                            {
                                Body = "A combination of my notes and previous projects saves me many hours of head-banging. I use <a href='https://roamresearch.com/'>RoamResearch</a>. I think it’s superior to anything I’ve ever used, but Evernote, Google Docs and even your computer’s notepad will do. Keep your notes organized."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "One Thing At A Time",
                        ImgUrl = "icons8-to-do-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "I have a wandering mind, extreme curiosity and several areas of interest. If I don’t keep a tight leash on my mind, I jump around to the point I don’t get anything done. I can’t stress enough the importance of doing one thing at a time."
                            },
                            new Paragraph
                            {
                                Body = "Don’t work on 10 projects. <b><i><u>One at a time!</u></i></b> Actually, to be honest, I always work on two things, so If I get bored or stuck I can always jump to the other to make me feel better. But still, one of them has to be your main goal. "
                            },
                            new Paragraph
                            {
                                Body = "I know so many clever students who have been learning for a long time and have nothing to show for. No portfolio, no projects, nothing. And doing too many things is one of the reasons. "
                            },
                            new Paragraph
                            {
                                Body = "The same applies to your daily life. Don’t cram 20 tasks into your daily schedule. Do one or two big things a day and consider yourself successful for that day. My thing was always coding. If I did my four hours, I won the day. You can have a study goal and parallel goal such as running an important errand or something. But keep it achievable. <b><i><u>You want to win your days</u></i></b>."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Mindset",
                        ImgUrl = "icons8-to-do-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>I read a lot</u></i></b>. I attribute a lot of my success in my programming journey to the scope and depth that reading has given me. Actually, I don’t read, I listen. Books and podcasts. They are absolutely life-changing."
                            },
                            new Paragraph
                            {
                                Body = "If you don’t have some form of input in your life, you’re missing out. In our days technology gives access to curated information easily accessible at any time. Indirect mentorship through podcasts, audiobooks, youtube channels. Yet some of us think that we don’t need it, we know it all."
                            },
                            new Paragraph
                            {
                                Body = "There are a few exceptions out there, but the vast majority of high achievers, the people who run things in this world, are avid readers. If you don’t like it, start liking it. It will pay off. <b><i><u>I promise</u></i></b>."
                            },
                            new Paragraph
                            {
                                Body = "There are many books I could recommend but to keep it simple, the most important are:"
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "40121378-678x1024.jpg",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>Atomic Habits</u></i></b> by James Clear – It will help you to get your habits in order. Backed by many amazing anecdotes and scientific studies, if you listen to it over and over, trust me, you’ll be a better person."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "27213329-672x1024.jpg",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>Grit</u></i></b> by Angela Duckworth – This book will demonstrate, also with science and anecdotes, that you should forget about the word talent. Most folks who achieve great success are the ones that <b>SHOW UP CONSISTENTLY</b> and do the hard work."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What Happens From Here",
                        ImgUrl = "icons8-where-what-quest-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Once you finish reading this page, <a href='https://discord.gg/JVnwYdM79C'>join us on Discord</a> and introduce yourself.  If the link doesn’t work, add me via my nickname: <b><i><u>pablocappuccino#4729</u></i></b>. We can either work closely together with constant feedback and a clear plan, or you can roam free and get back to us whenever you need. "
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
                        ImgUrl = "icons8-whispering-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want instant rewards, or if you believe you’ll start earning six figures doing something that doesn’t require a lot of effort, this isn’t for you. If you can’t stand the long hours of hard work,  or if you don’t like getting stuck and taking days, sometimes weeks to fix a problem, you might not have the grit, or be passionate enough about coding to make this happen. Maybe this isn’t for you and that’s fine. It might sound harsh but that’s the reality of what it takes to become a programmer (and I would guess, to be good at anything for that matter)."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>Most people who start learning to code quit in less than 6 months</u></i></b>. If you stick to it, imagine that in 2 years it’s highly likely you’ve got many interviews and got at least close to a job. Five years training consistently? You’ll probably not only be employed but also making very good money. Now imagine ten years consistently building stuff. I would say it’s impossible you’re not hired and earning great money."
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
                IconUrl = "icons8-helping-96.png",
                Description = "You’ll get stuck. Many times. It’s the life of a developer. Find out how to solve problems like a professional programmer and where to get help.",
                Area = Area.StartHere,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        ImgUrl= "icons8-anxious-96.png",
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
                        ImgUrl= "icons8-headache-60.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The sooner you understand that this is the nature of the work, the better. Your attitude towards these errors is the single most important factor that will determine your success. I know it can be disheartening sometimes. I’ve been stuck with errors for weeks. So what kept me going? I have two thought patterns that I trained myself to use in difficult programming situations:"
                            },
                            new Paragraph
                            {
                                Body = "1 – Quitting is not an option.<br>2 – “We have a drone on Mars”. If we are able to control a drone on Mars, <b><i><u>THERE IS A SOLUTION</u></i></b> for whatever programming problem I’m having."
                            },
                            new Paragraph
                            {
                                Body="Remember this: <b><i><u>THERE IS A SOLUTION</u></i></b>. It will take many years of programming to run into problems that haven’t been solved before. So if you stick to it, no matter how long it takes, you will solve it. So let’s see how we solve problems in software development."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Double Check Your Code",
                        ImgUrl= "icons8-magnifying-glass-64.png",
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
                        ImgUrl= "icons8-error-64.png",
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
                        ImgUrl= "icons8-google-shopping-96.png",
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
                        ImgUrl= "icons8-stack-overflow-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you google the problem using your own words or copying and pasting the error, you’ll quickly find out that most of these questions have been answered on <a href='http://stackoverflow.com/'>Stackoverflow.com</a>."
                            },
                            new Paragraph
                            {
                                Body = "Even though you’ll find answers in different resources, this is the most reliable forum for programmers. You should create an account and if you can’t fix a certain problem, post your code and you’ll get help."
                            },
                            new Paragraph
                            {
                                Body = "<a href='https://stackoverflow.com/users/11659311/pablo-aguirre-de-souza?tab=answers&sort=votes'>Have a look at my account on stack overflow</a> and you’ll see that I asked tons of questions throughout my journey. Most of these questions weren’t unique. They were problems that have already been solved but I couldn’t translate them into my code. With experience you’ll be able to adapt someone else’s answers to your code, but sometimes you’ll have to post your own for someone else to have a look."
                            },
                            new Paragraph
                            {
                                Body = "Remember. <b><i><u>THERE IS A SOLUTION</u></i></b>."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Ask Someone",
                        ImgUrl= "icons8-apologise-96-1.png",
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
                        ImgUrl= "icons8-relax-96.png",
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
                IconUrl = "icons8-project-setup-96-1.png",
                Description = "Learn how to set up your develop environment with .NET framework and Visual Studio so you can get ready to start coding.",
                Area = Area.StartHere,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        ImgUrl= "c-logo-icon-28402-1-300x288.png",
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
                        ImgUrl= "icons8-visual-studio-2019-96-1.png",
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
                        ImgUrl= "icons8-visual-studio-2019-96-1.png",
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
                                Body = @"<a href='https://www.youtube.com/watch?v=nvTwDirvwIw&t=4s'>Visual Studio for Windows</a><br>
                                         <a href='https://www.youtube.com/watch?v=KMXm43LVNeY&t=36s'>Visual Studio for Mac</a><br>
                                         <a href='https://www.youtube.com/watch?v=r5dtl9Uq9V0'>Visual Studio Code for Windows</a><br>
                                         <a href='https://www.youtube.com/watch?v=LXxjCNfd5b4'>Visual Studio Code for Mac</a><br>
                                         <a href='https://www.youtube.com/watch?v=3YIADWbQFzE'>Visual Studio Code for Linux</a><br>"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl= "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Ok, almost good to go. Now you need a source control system. This is where you’ll back up your work and share it with other people. It’s an absolute must for developers and I recommend you start looking into it straight away. The most common source control system is Git. One of the tools invented by the genius Linus Torvalds, the creator of Linux. The most common platform is Github. <a href='https://www.youtube.com/watch?v=QUtk-Uuq9nE'>Here's a quick tutorial on how to create a Github account</a>."
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
                        ImgUrl= "icons8-google-docs-96-1.png",
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
                                Body = "If you want to go fancy, try Evernote or the one I use on a daily basis: <a href='http://roamresearch.com/'>Roamresearch.com</a>. It’s paid but it’s the best I’ve seen so far. Whatever you do, keep your notes simple and organised. Back them up and protect them with your life. "
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 8,
                Title = "C# Foundations",
                IconUrl = "icons8-sharp-94.png",
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
                                Body = "It’s time to start coding! Welcome to fantastic world of C#! If you haven’t yet, checkout the <a href='https://www.thecsharpacademy.com/setup/'>C# Setup</a> article. You’ll need to set up your C# developer environment before starting."
                            },
                            new Paragraph
                            {
                                Body = "Now it’s time to learn the basic C# syntax. You need to be familiar with a few concepts and techniques before jumping into your first real project. The way you’ll attack this first contact with the language will depend on your learning style, but here’s my advice: Don’t try to understand <b>EVERYTHING</b> before starting to build."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "You don't need a lot to start building",
                        ImgUrl= "icons8-builder-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "One of the biggest mistakes people make when starting to code is assuming they need to know <b>A LOT</b> before building interesting things. You’ll be surprised about what you can create with basic concepts you can learn within a few hours."
                            },
                            new Paragraph
                            {
                                Body = "By all means, make lots of notes when you’re first learning to code. Go through the entire material once or twice. But that’s it! The basic syntax hasn’t and won’t change significantly across the years. You’ll have to get back to the basics many times during your journey. Everything you initially have contact with will only be internalised with <b>PRACTICE</b>. So make sure you don’t spend more than a few hours learning the basic theory."
                            },
                            new Paragraph
                            {
                                Body = "Here’s an example of your self-talk when you start your first project: '<i>Oh, what do I need to do here? I think an if-else statement will be good to get the user input. How do I write it again? I remember I saw it in the documentation, but I’m not quite sure</i>'. Then you’ll go back to your notes or the documentation, get what you need and apply in your code. You won’t know exactly how to do it, or even how it works yet, but you’ll know where to look and learn how it’s applied once you use it. "
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
                                Body = "Here’s a playlist of videos with an intro course by the C# Academy with the aim of providing the foundation you need for the upcoming projects. It differs from most beginners tutorials because we don’t just teach concepts that you have no idea how to apply in a real program. We will create a desktop game so that you see how each concept is applied in the context of a real world application."
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
                                VideoUrl = "https://www.youtube.com/embed/iLByqqLGYEc"
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
                        ImgUrl= "icons8-bill-gates-100-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Even if you don’t love Bill Gates, you have to concede that Microsoft is great. Not only did they change the world forever with their products but they also created a programming language and will teach you how to use it! "
                            },

                            new Paragraph
                            {
                                Body = "Their documentation is very comprehensive and you can learn all of the basics just going through their beginners course. However be careful not to get lost. They offer so much material you could just use their academy forever. At this stage, stick to their <a href='https://docs.microsoft.com/en-gb/users/dotnet/collections/yz26f8y64n7k07?WT.mc_id=dotnet-35129-website'>Learn C#</a> session. If you really need to, go through everything one more time, and that’s it! Time to jump into your first project."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Creating Your Library",
                        ImgUrl= "icons8-books-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In the <a href='https://www.thecsharpacademy.com/setup/'>C# Setup</a> article , you learned you have to create your source control repository. This will be your ultimate reference book. Every piece of code you ever write should be saved there. And guess what? That will also become your tool box. You’ll constantly grab pieces of code you’ve written before to reuse in your projects. "
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
                        ImgUrl= "external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s great to learn from different sources. While we’re biased towards C# Academy’s beginner’s tutorial above, since it’s unique in that you learn concepts by applying them, we strongly encourage you to learn from different instructors throughout your journey. Here’s my favourite <a href='https://www.youtube.com/watch?v=gfkTfcpWqAY'>Beginners tutorial</a>. Mosh touches on everything you need to get started and after this video you can jump straight into the projects. <a href='https://www.youtube.com/playlist?list=PLLWMQd6PeGY2GVsQZ-u3DPXqwwKW8MkiP'>Tim Corey</a> is another excellent instructor to get started with."
                            },
                            new Paragraph
                            {
                                Body = "The <a href='https://www.youtube.com/watch?v=GhQdlIFylQ8&t=8242s'> most watched C# course</a> on Youtube is excellent but it’s 4 hours long. It might take you weeks to watch it. I suggest you don’t go through the whole thing before jumping into projects. That’s exactly the type of behaviour that makes people quit. Initially stay away from super long, comprehensive tutorials, unless you break them in pieces and mix theory with practice. "
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
                        ImgUrl= "icons8-prepositions-next-to-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"Just for reference, here’s a list of things you need to be familiar with before your first project:<br><br>
1. How to run a C# program<br>
2. Basic syntax<br>
3. Dealing with strings<br>
4. Data Types<br>
5. Variables<br>
6. Getting input from an user<br>
7. Basic maths operations<br>
8. C# helper methods<br>
9. How methods work<br>
10. Control-flow<br>
11. Arrays and Lists<br>
12. Loops"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 9,
                Title = "The Importance of Console Applications",
                IconUrl = "icons8-baby-app-96.png",
                Description = "Building console applications will allow you to focus on the back end before diving into the complexities of front-end. Here’s why.",
                Area = Area.Console,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        ImgUrl= "icons8-command-line-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Web technologies are developing extremely fast. Websites these days are faster, more efficient, better looking and provide great user experience. When starting to learn web development, it’s easy to get tempted by all the hype of the latest frameworks. I started with Angular myself. I loved it from the moment I wrote my first component."
                            },
                            new Paragraph
                            {
                                Body = "But I quickly realised if I wanted to deal with data in the capacity I wanted, I would need to learn a back-end language. I took an approach that I find less than ideal. I dove into a bunch of tutorials about how to build full-stack apps. That made it very difficult for me to understand back-end properly. I wish I knew there was a better approach."
                            },
                            new Paragraph
                            {
                                Body = "Now I find it much more effective to build Console Apps to learn back-end. And the reason is simple: Focus. You can dedicate your full attention to your back-end language if you don’t have to worry about all the complexities of presenting data to the user in a beautiful way."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl= "icons8-console-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "That’s why I decided to make the first part of this program purely focused on Console Apps, without any front-end distractions. These apps will help progressively teach you: data types; basic control flow and syntax; dealing with databases; creating and calling APIs; Entity Framework; Repository Pattern and Unit Testing. As you can see there’s already a lot to keep you busy. "
                            },
                            new Paragraph
                            {
                                Body = "That doesn’t mean you won’t have an user interface. But instead of the website, you’ll be interacting with the user via the console line. You’ll still need to handle validation, basic presentation and all sorts of errors to provide a good user experience. And this knowledge will definitely transfer when you start creating full-stack apps."
                            },
                            new Paragraph
                            {
                                Body = "I know we all want to create fancy things as soon as possible. Even when I was creating this library of console apps, I was looking forward to going back to the latest web technologies, Maui, Blazor, Angular, Ionic, React, they are beautiful! But without a solid back-end foundation we’re very limited. The competition for a job is tough out there. You need to stack the deck in your favour. And it starts here, writing simple, clean, effective console programs. Now let’s start"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 10,
                Title = "Graduation!",
                IconUrl = "icons8-graduate-96.png",
                Description = "This is your graduation from Console Apps! Find out how to start applying for jobs and what are the next steps in your coding journey.",
                Area = Area.Console,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Congratulations",
                        ImgUrl= "hexternal-celebration-soccer-and-football-match-kosonicon-lineal-color-kosonicon-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Well done!! If you got this point, I’m sure you feel accomplished. It wasn’t easy. You were probably frustrated and disheartened at times. You felt stuck and maybe even thought of quitting. But you pushed through! And now you can proudly affirm you know the basics of back-end development with C#. How are you planning to celebrate? 🍾 You deserve it!! 😁"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What you've learned",
                        ImgUrl= "icons8-checklist-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"✅ Basic C# Syntax and Control Flow<br>
✅ Console Application Techniques: User Input and Validation<br>
✅ Basic SQL Syntax and Crud Commands\r\nPrinciples of MVC Design: Models, Controllers, UI, Services, Validators<br>
✅ Interaction with files in your file system.<br>
✅ Calling an External Api with Http Requests.<br>
✅ Entity Framework<br>
✅ Creating and calling Web APIs.<br>
✅ Webscrapping <br>
✅ Sending e-mails with code<br>
✅ Fundamentals of Unit Testing<br><br>
That's a lot!! Again... Well done!!!"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What Happens From Here",
                        ImgUrl= "icons8-where-what-quest-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Now that you have a good understanding of the basic principles of back-end web development with C#, what’s the next step? Well, there’s a lot to do! ASP.NET is endless, but as I said before, most of what you’ll do from now on is a variation of what you’ve already done. Calling databases, getting the user input and processing data in between."
                            },
                            new Paragraph
                            {
                                Body = "The next steps in this program involve building full-stack applications with the following:"
                            },
                            new Paragraph
                            {
                                Body = @"➡️ ASP.NET MVC With Razor Syntax<br>
➡️ Securing Your App With Authorisation and Authentication With Asp.NET Identity<br>
➡️ Deploying your full-stack app with Azure, Firebase<br>
➡️ Desktop Applications With WPF and XAML<br>
➡️ Single Page Applications with Blazor<br>
➡️ Mobile Applications With Xamarin Forms (and hopefully with .NET MAUI)<br>
➡️ CRUD Applications With React<br>
➡️ CRUD Applications With Angular<br><br>
But I'll be surprised if you get to the end of this list and you don't have a job yet."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Before We Continue",
                        ImgUrl= "icons8-permanent-job-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Before we continue with our .NET C# program, I have to tell you. What you have done so far might be enough to land you a job. Yes, that’s right. The demand for C# developers is so high that a handful of console apps might suffice. "
                            },
                            new Paragraph
                            {
                                Body = "So while you learn everything else .NET has to offer, you’ll be also applying for jobs, with a decent chance of success. But we need to get organised first. You need a portfolio and a resume."
                            },
                            new Paragraph
                            {
                                Body = @"While a portfolio isn’t absolutely necessary to land you a job, it does increase your chances. You’ll read more about it in the Portfolio Area. So let’s get ready for our next three steps:<br><br>
✔️ Creating a Portfolio<br>
✔️ Creating a Resume<br>
✔️ Applying for Jobs<br>"
                            },
                            new Paragraph
                            {
                                Body = "If you don’t want to look for jobs right now, you can jump straight to the MVC Area, but I strongly recommend you still create a portfolio. Check out the portfolio project to understand why."
                            }
                        }
                    }
                }
            }
        };
    }
    public static List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 11,
                Title = "Calculator",
                IconUrl = "icons8-calculator-512.png",
                Description = "In your first project, you’ll create a calculator with the help of Microsoft's Documentation",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In your first project you’ll build a Console Calculator App with the help of Microsoft’s Documentation. If this is your first time building a project on your own, I suggest you first watch <a href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> this series from our C# Foundation area</a>, where we walk you through how to create a console app from scratch, while explaining important concepts in C#. If you have already watched it, or created applications before, this will be a breeze. But it’s still helpful to reinforce your knowledge. "
                    },
                    new Paragraph
                    {
                        Body="It will also serve as practice in a very important skill: following written documentation. This is something you’ll be doing on a regular basis as a professional developer, so it’s essential that you’re comfortable applying text-based instructions when developing software."
                    }
                },
                Requirements = new List<string>
                {
                    @"Complete the following tutorial: <a href='https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022'>Create a Calculator App (Microsoft Docs)</a>"
                },
                RequirementsIntro = "This project has only one requirement:",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-mac'>Visual Studio For Mac</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0'>Visual Studio Code</a>"
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
                        ImgUrl = "icons8-git-96.png",
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
                                Body="1. In Visual Studio, go to Git > Create Git Repository<br>2. Enter your Login Details<br>3. Click on Create and Push. "
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
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='https://www.thecsharpacademy.com/code-reviews'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Creating a Desktop App",
                        ImgUrl = "icons8-desktop-computer-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the <a href='https://www.thecsharpacademy.com/code-reviews'>entire C# Foundation course</a>, you have already created a <a href='https://www.thecsharpacademy.com/code-reviews'>Math Game Desktop app using the amazing .NET MAUI</a>. It will be great practice to build a desktop Calculator App with the same functionality you’ve created for this console app. There will be some challenges, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on Discord and we will help!"
                            }
                        }
                    }
                }

            },
            new Project
            {
                Id = 12,
                Title = "Habit Logger",
                IconUrl = "icons8-calendar-plus-96.png",
                Description = "Build a logger for a habit of choice. Learn how to interact with a database using SQLite and to get and validate user input",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This is a very simple app that will teach you how to perform <a href='https://en.wikipedia.org/wiki/Create,_read,_update_and_delete'>CRUD operations</a> against a real database. These operations are the base of web-development and you’ll be using them throughout your career in any most applications. We think it’s very important to do it from the start of your journey, since everything that will happen from here is just adding complexity to CRUD operations. No matter how complex and fancy the app you’re building is, in the end it all comes down to executing CRUD calls to a database."
                    },
                    new Paragraph
                    {
                        Body="For that you’ll have to learn very simple <a href='https://en.wikipedia.org/wiki/SQL'>SQL commands</a>. I know it sounds scary, but you’ll be amazed about how little SQL knowledge you need to build a full-stack app. Don’t worry, we will take you by the hand and by the end you’ll have completed your first fully functioning CRUD app. The most common ways of calling a SQL database with C# are through <a href='https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/'>ADO.NET</a>, Dapper and Entity Framework. We will start by using ADO.NET, because it’s the closest to raw SQL."
                    },
                    new Paragraph
                    {
                        Body="If you think this project is too hard for you and you have no idea where to even start, you’re probably right. You might need an extra hand to build a real application on your own. If that’s the case, <a href='https://youtu.be/d1JIJdDVFjs'>watch the video tutorial for this project</a> and then come back and try it again on your own. It’s perfectly ok to feel lost, since most beginner courses don’t actually teach you how to build something. "
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
                    "Your project needs to contain a Read Me file where you'll explain how your app works. Here's a nice example:"
                },
                RequirementsConclusion = "<a href='https://github.com/thags/ConsoleTimeLogger'>Github project with an example of a tidy Read Me file.</a><br>Don't panic! I'll help! 😁",

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
                 LearningIntro = "If you have learned the basics of C# following the <a href='https://www.thecsharpacademy.com/foundations/'>C# Foundations</a> article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
                 LearningItems = new List<string>
                 {
                     "Taking user input from the console.",
                     "Printing messages on the console. ",
                     "Installing nuget packages (ASP.NET libraries that will help you write your program).",
                     "Basic control flow with 'if-else' and 'switch statements'",
                     "Connecting to a Sqlite database.",
                     "Basics of SQL(the language you use to communicate with the database). If you want to train some SQL before getting started, <a href='https://www.w3schools.com/sql/sql_exercises.asp'>here's an excellent place</a>."
                 },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Creating The Project",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This tutorial requires that you already have set up your .NET environment. If you haven’t yet, check <a href='https://www.thecsharpacademy.com/setup/'>this article</a> out with the first steps. If you absolutely want to use another IDE, let me know."
                            },
                            new Paragraph
                            {
                                Body = "1. In Visual Studio, choose Create new project. If you’re using Visual Studio Code, let me know if you have difficulties creating the project.<br>2. Search for Console Application and click Next.<br>3. Choose a Project Name and a Location and click Next.<br>3. Choose the latest framework (Net 6 at the time of this tutorial) and click Create.<br>4. Run your application by clicking on the green play button on the top of the screen."
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
                        ImgUrl = "icons8-folder-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This way .NET will build your project in your main folder. By default it builds your project in a bin folder and just to keep things simple we want to avoid that. That will create a Properties folder with a <b>launchsettings.json</b> file containing your configuration information. This is an important step only for applications that use Sqlite because you want the database to be created in the same folder of the application to avoid confusion."
                            },
                            new Paragraph
                            {
                                Body = "For that, click on the chevron next to the name of your app on the top menu, click on {nameoftheapp} Debug Properties and copy the path of your directory to the 'Working Directory' field. To find out what your path is, you can right click on your project in the Solution Explorer and on “Copy Full Path” or look it up in your Files Explorer. If you’re using Mac/Visual Studio Code, reach out and I’ll tell you how to do it. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "MicrosoftTeams-image-1.png"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "MicrosoftTeams-image-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Start Coding!",
                        ImgUrl = "icons8-coding-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Every time you start your app, it should check if there’s a database. If there isn’t, it will create one along with a table where you’ll store your data. If you delete your database externally, it will always create one. If the database exists, it will move to the next step: take the user input about what you want to do. Something like this:"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "Copy-of-Copy-of-ASP.NET-MVC-PROJECT-768x432.png"
                            },
                            new Paragraph
                            {
                                Body = "In ASP.NET C# development, the use of SQL Server is very common. But we won’t be using it here. SQLite is a super lightweight database system and it’s important to get familiar with it before jumping into SQL server."
                            },
                            new Paragraph
                            {
                                Body = "You’ll need to tell your program to create a sqlite file. You’ll be able to visualise that file externally with the help of a small application. <a href='https://www.youtube.com/watch?v=oeuTw00F1as&t=725s'>Here's a link to a basic sqlite tutorial</a>."
                            },
                            new Paragraph
                            {
                                Body = "That’s where your actual code begins! You’re on your own for a while. If you get stuck, keep trying, <a href='https://www.thecsharpacademy.com/get-help/'>remember the steps to debug your app</a>. And if you ultimately can’t do it, reach out to our <a href='https://discord.com/channels/925901888203935744/925901888203935747'>Discord Community</a> or myself and we will help!"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Video Tutorial",
                        ImgUrl = "external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you’re feeling totally lost, it’s perfectly ok to watch a video tutorial to get you going. Here you’ll learn to connect all the pieces to build a real application. Once you finish it, make sure you try it again on your own without the help of the video so you internalise the newly acquired knowledge. "
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/d1JIJdDVFjs"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl = "icons8-git-96.png",
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
                                Body="1. In Visual Studio, go to Git > Create Git Repository<br>2. Enter your Login Details<br>3. Click on Create and Push. "
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
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='https://www.thecsharpacademy.com/code-reviews'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Next Step: Desktop App",
                        ImgUrl = "icons8-staircase-80.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>entire C# Foundation course</a>, you have already created a Math Game Desktop app using the amazing .NET MAUI. It will be great practice to build a desktop Habit Tracker App with the same functionality you’ve created for this console app. There will be some challenges, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on Discord and we will help!"
                            }
                        }
                    },
                }
            },
            new Project
            {
                Id = 13,
                Title = "Coding Tracker",
                IconUrl = "icons8-smart-watch-96.png",
                Description = "Track your coding hours. Learn how to deal with dates, to use separation of concerns and use your first external library to enhance your application",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This app should be very similar to the <a href='https://www.thecsharpacademy.com/habit-tracker'>Habit Tracker</a> you’ve previously completed. It will serve the purpose of reinforcing what you’ve learned with a bit of repetition and building on that knowledge with slightly more challenging requirements. "
                    },
                    new Paragraph
                    {
                        Body="This time you’ll have to deal with the complexity of handling Dates and Times, which is a real challenge in any application. You’ll also be using your first external library. Often times in professional environments programmers don’t reinvent the wheel and save time by using public solutions provided by other coders. That’s the beauty of the internet. You have access to an amazing coding community! "
                    },
                    new Paragraph
                    {
                        Body="In the first app we also didn’t have requirements for coding organization. This time you’ll have to use <a href='https://en.wikipedia.org/wiki/Separation_of_concerns'>separation of concerns</a>, one of the most important principles in modern programming. This is where you’ll start applying concepts of Object Oriented Programming. You’ll also need to use a “Model”  or “Entity”, to to represent the data you are dealing with. In this case, your coding sessions. So let’s get started!"
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
                    "Installing <a href='https://github.com/minhhungit/ConsoleTableExt'>ConsoleTableExt</a> using <a href='https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio'>Nugget Packages</a>.",
                    "<a href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Using Configuration Manager</a>",
                    "<a href='https://stackoverflow.com/questions/371987/how-to-validate-a-datetime-in-c'>Parsing DateTime in C#</a>"
                },
                ResourcesIntro = "If you have learned the basics of C# following the <a href='https://www.thecsharpacademy.com/foundations/'>C# Foundations</a> article, and completed the <a href='https://www.thecsharpacademy.com/habit-tracker/'>Habit Tracker</a> project, you should know all the basic techniques needed to complete this project. Here’s a list of extra resources you might need:",
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
                        ImgUrl = "external-configuration-computer-itim2101-lineal-color-itim2101-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In advanced applications, configuration properties are stored in an xml file. This practice makes it easier to configure your application in production. It’s not absolutely necessary now, but it’s not hard to learn and you should get used to it from the beginning of your coding journey. It makes your code cleaner and more organised. <a href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Check out the documentation</a> and if necessary search for “configuration file C#” on Youtube. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Creating a Desktop App",
                        ImgUrl = "icons8-desktop-computer-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>entire C# Foundation course</a>, you have already created a Math Game Desktop app using the amazing .NET MAUI. It will be great practice to build a desktop Coding Tracker App with the same functionality you’ve created for this console app. There will be some challenges, especially if you want to create a timer, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on Discord and we will help!"
                            }
                        }
                    }
                }
            },
            new Project
            {
                Id = 14,
                Title = "Flashcards",
                IconUrl = "icons8-quizlet-96.png",
                Description = "Building stacks of flashcards and a study functionality. Learn to deal with linked databases using SQL Server and to use Data Transfer Objects",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="After the first two projects, you should be somewhat comfortable with how things work in C#. It’s time to make things slightly more complex. You’ll be using  <a href='SQL Server'>entire C# Foundation course</a> for the first time. We could continue using SQLite, as it does everything needed for most small applications, but SQL Server is heavily used in the industry and the sooner we get familiar with it, the better."
                    },
                    new Paragraph
                    {
                        Body="This time the database will be a little more complex as well. We will have two tables linked by a foreign key. And for the first time we will be working with  <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>DTOs (Data Transfer Objects)</a>, which will help us use the same object in different ways."
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
                LearningIntro = "If you have learned the basics of C# following the  <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>C# Foundations </a> article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
                LearningItems = new List<string>
                 {
                     "Using SQL Server.",
                     "Creating linked tables with SQL.",
                     "Using DTOs to create different versions of classes.",
                     "<a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>Pivoting Tables in SQL</a>"
                 },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Installing SQL Server",
                        ImgUrl = "icons8-sql-server-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This is the first project in the academy where we’ll be using SQL Server. <a href='https://docs.microsoft.com/en-us/sql/tools/visual-studio-code/sql-server-develop-use-vscode?view=sql-server-ver15'> You can work with SQL Server using Visual Studio.</a>. But I recommend you start using Microsoft SQL Server Management Studio. For this app, don’t use SQL Server EXPRESS, but only LOCAL DB. <a href='https://www.youtube.com/watch?v=QsXWszvjMBM'> Here’s a tutorial on how to install the studio</a>. And here’s a tutorial on <a href='https://www.youtube.com/watch?v=M5DhHYQlnq8'> how to connect to your localdb</a> "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Challenge",
                        ImgUrl = "icons8-courage-96.png",
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
                                PictureUrl = "Screen-Shot-2022-04-04-at-6.49.23-am-1-1024x305.png"
                            }
                        }
                    }
                },
                Screenshots = new List<string>
                {
                    "Screen-Shot-2022-04-04-at-6.42.37-am.png",
                    "Screen-Shot-2022-04-04-at-6.44.38-am.png",
                    "Screen-Shot-2022-04-04-at-6.45.08-am.png",
                    "Screen-Shot-2022-04-04-at-6.45.19-am.png",
                    "Screen-Shot-2022-04-04-at-6.46.40-am.png",
                    "Screen-Shot-2022-04-04-at-6.47.43-am-150x150.png",
                    "Screen-Shot-2022-04-04-at-6.48.09-am-150x150.png"
                }
            },
            new Project
            {
                Id = 15,
                Title = "Drinks Info",
                IconUrl = "89-897207_alcohol-alcoholic-bar-cafe-cocktail-mixed-drink-party-drinks-clipart-png.png",
                Description = "Build a console app to consume an external API with HTTP Requests with C#",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Often times developers work with third-party data. A very common way of accessing external vendor’s data is to make requests to their APIs (Application Programming Interface). Once we have access to their data, we can process in our application to suit our needs. Another common scenario is when an organisation has multiple independent applications that communicate amongst themselves. <a href='https://en.wikipedia.org/wiki/Microservices'>The so called microservices</a>."
                    },
                    new Paragraph
                    {
                        Body="In this application we will learn how to connect to an external API through HTTP requests using .NET’s class library. It‘s easier than you imagine! Luckily there are many public APIs out there. <a href='https://github.com/public-apis/public-apis'> Here’s a great list of public APIs for practice.</a>"
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
                    "<a href='https://www.thecocktaildb.com/api.php'>Cocktail Database</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient'>Microsoft Docs: Http Requests</a>"
                },
                Screenshots = new List<string>
                {
                    "Screen-Shot-2021-12-12-at-11.09.56-am.png"
                }
            },
            new Project
            {
                Id = 16,
                Title = "Phone Book",
                IconUrl = "icons8-contact-book-512-150x150.png",
                Description = "Now you have basic understanding of SQL, it’s time to learn the basics of Entity Framework with a CRUD Phone Book Console App",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In the .NET ecosystem you’ll come across <a href='https://stackoverflow.com/questions/1279613/what-is-an-orm-how-does-it-work-and-how-should-i-use-one'>ORMs (Object-Relational Mappers)</a>, which helps you to deal with databases using objects. If you have searched for C# tutorials you’ve probably encountered technologies such as Dapper and Entity Framework. You’ll definitely be using one when you start working as a developer."
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
                    "<a href='https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli'>Entity Framework Docs</a>",
                    "<a href='https://www.youtube.com/watch?v=Jnv7hNNuTqs'>CRUD Console APP with EF on Youtube</a>"
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
                Id = 17,
                Title = "Shifts Logger",
                IconUrl = "icons8-nurse-256.png",
                Description = "Build an App for shift workers to log their hours. In this app you’ll learn how to build a Web API and consume it with a Console App",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="If you’ve been learning to code for more than five minutes, you probably heard about <a href='https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Client-side_web_APIs/Introduction'>'APIs'</a>. They’re at the core of back-end programming. In web development, their main job will be to communicate with databases using “endpoints”. From now on you’ll be creating APIs all the time and this acronym will forever be part of your vocabulary. "
                    },
                    new Paragraph
                    {
                        Body="In the <a href='https://www.thecsharpacademy.com/drinks-info/'>Drinks Info App</a> we have created a program that consumed an external API. This time we will track a worker’s “shifts”. We’ll create an API and the console app that will consume it. When using Microsoft’s Documentation, often times you’ll come across Web APIs being developed with Entity Framework, which acts as layer between the “endpoints” and the actual database. "
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
                    "<a href='https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Client-side_web_APIs/Introduction'>What are APIs?</a>",
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio'>Web API Docs</a>",
                    "<a href='https://www.youtube.com/watch?v=IYWOWxw7dys'>Testing Web APIs with Swagger</a>",
                    "<a href='https://www.youtube.com/watch?v=FjgYtQK_zLE'>Postman Youtube Tutorial</a>"

                },
                Tips = new List<string>
                {
                    "If this is your first contact with .NET Web API, follow the tutorial closely using the Todo List data model and http-repl for testing. In a second moment, follow the tutorial one more time, this time following the project's requirements.",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "First, create the Web API project, then use Swagger and Postman to test it. Only then create the UI project.",
                    "You might be tempted to skip testing with Swagger and Postman. Don't make that mistake. These tools are essential for working with web apis in enterprise and your hiring managers will be unimpressed if you are not familiar with them.",
                    "Calculate the duration of the shift based on its start and end.",
                },
                Screenshots = new List<string>
                {
                    "Screen-Shot-2022-02-11-at-7.17.46-am-768x444.png"
                }
            },
            new Project
            {
                Id = 18,
                Title = "Exercise Tracker",
                IconUrl = "icons8-bench-press-96.png",
                Description = "Learn the repository pattern, the most common design pattern for interaction with databases",
                Area = Area.Console,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="So far we have been developing our applications without thinking too much about their design. In software development, we’ll often use “general repeatable solutions to commonly occurring problems”, <a href='https://en.wikipedia.org/wiki/Software_design_pattern'>the so called design patterns</a>."
                    },
                    new Paragraph
                    {
                        Body="We will build an exercise tracker using the “Repository Pattern”, an almost universally used solution for data persistence. It creates a layer between business logic and data access, which helps us create more loosely-coupled, testable and maintainable applications. <b>You’ll be dealing with repositories on a daily-basis when you get your C# job!</b>"
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
                    "<a href='https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli'>Repository Pattern Docs</a>",
                    "<a href='https://www.programmingwithwolfgang.com/repository-pattern-net-core/'>Repository Pattern Tutorial</a>",
                    "<a href='https://www.youtube.com/watch?v=Jnv7hNNuTqs'>Repository Pattern with EF on Youtube</a>"
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
                Id = 19,
                Title = "Sports Results Notifier",
                IconUrl = "icons8-sports-96.png",
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
                    "<a href='https://html-agility-pack.net/'>Agility Pack Docs</a>",
                    "<a href='https://www.c-sharpcorner.com/blogs/send-email-using-gmail-smtp'>Send An Email Using Gmail SMTP and C#</a>",
                    "<a href='https://www.youtube.com/watch?v=L6OybsujX1Y'>Agility Pack Tutorial</a>",
                    "<a href='https://www.basketball-reference.com/boxscores/'>Basketball Reference</a>"
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
                Id = 20,
                Title = "Excel Reader",
                IconUrl = "excel.png",
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
                ResourcesIntro = "The knowledge you gained from the previous three projects will be enough to complete this project.You’ll only need to find out how EPPlus Package works. <a href='https://www.youtube.com/watch?v=kBwmP-kLEEE'>Here's a good Youtube tutorial</a>. If it’s not enough search for further videos on Youtube and/or specific questions in StackOverflow 😁",
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
                Id = 21,
                Title = "Unit Testing",
                IconUrl = "icons8-test-tube-100.png",
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
                    "<a href='https://fortegrp.com/the-importance-of-unit-testing/'>The Importance of Unit Testing</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest'>MSTest Docs</a>",
                    "<a href='https://www.youtube.com/watch?v=HYrXogLj7vg'>Unit Testing C# Code on Youtube</a>"
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
                Id = 22,
                Title = "Portfolio",
                IconUrl = "icons8-portfolio-512.png",
                Description = "Time to create a portfolio! Let’s present your work using a nice front-end technology of your choice",
                Area = Area.StartApplying,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="It’s time to build your portfolio! But why? It can be argued that you can get a job without one. And it’s true. Many organisations don’t look at portfolios when hiring. So why bother? Let’s discuss a few reasons."
                    },
                    new Paragraph
                    {
                        Body="<b><i><u>You want to stand out</u></i></b>. It’s a highly competitive world out there. The fight to get through the tech industry job without any experience is tough. So you want to stack the deck in your favour by doing all you can to stand out. Your portfolio will convey an image of you. It will show that you care, that you’re organised, that you have a plan for your learning. It will show your design skills. Either you want it or not, you have a brand, everyone does. And a portfolio will make your brand stronger."
                    },
                     new Paragraph
                    {
                        Body="<b><i><u>It pushes you</u></i></b>. I’d even go as far as saying that you should build a portfolio before building any projects. That’s because it sets your vision. The vision of a full portfolio in a year time prevents you from procrastinating. It makes you get out of bed to code and put in the work. It keeps bugging you in the back of your mind: “<i>My portfolio is empty, I have to keep going</i>”. "
                    },
                     new Paragraph
                     {
                         Body = "It will also prevent you from quitting. No matter how many rejections you get, you know that if you keep building, eventually your portfolio will be so impressive that <b>YOU WILL GET NOTICED</b>. Imagine your prospective employer looking at your portfolio with projects covering dozens of different technologies? “<i>We gotta check her out!</i>”, they’ll think. "
                     },
                     new Paragraph
                     {
                         Body = "<b><i><u>It's a project in itself</u></i></b>: Building a portfolio is … <b>PART OF YOUR PORTFOLIO</b>! It will be part of your practice as a developer. You’ll have to choose a model, design it, look after the front-end details, put yourself in the viewer’s shoes, think of what to have in it, it’s great practice all-around."
                     },
                     new Paragraph
                     {
                         Body = "You’ll have to choose which technology to use: WordPress? HTML/CSS? Vanilla JS? A front-end framework? Choosing technologies is part of a developers job. And you get to practice that too. But enough talking about it, let’s do it!  "
                     }
                },
                Requirements = new List<string>
                {
                    "Your portfolio should be a static website",
                    "The following sections are required: A top area with a 'banner' or 'hero'; 'About me'; 'My work', 'Contact', Footer",
                    "You can use any technology you want: WordPress, a front-end framework, bootstrap or just the good old Html/Css/Vanilla Js combo.",
                    "The 'My Work' area should contain links to your github repositories. If you have full-stack web apps, it should contain links to their webpages.",
                    "Your portfolio should contain a \"Download Resume\" button, preferably in the top area.",
                    "It should be responsive and look good in any screen size."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://tamuk.quickstart.com/blog/10-full-stack-web-developer-portfolio-to-inspire-you/'>10 Full Stack Web Developer Portfolio to Inspire You</a>",
                    "<a href='https://medium.com/@traversymedia/10-web-developer-portfolio-tips-384491d408a8'>10 Web Developer Portfolio Tips</a>",
                    "<a href='https://www.youtube.com/watch?v=X6PwyH0thU0'>Portfolio So Good I Hired Him (Youtube)</a>"
                },
                Tips = new List<string>
                {
                    "Keep it simple. The best portfolios are the ones with an impressive amount of quality projects, not fancy, flashy, empty ones. Your goal here is to build your portfolio fast and get back to work.",
                    "Before publishing your portfolio, make sure it's reviewed by someone in the industry. If you post your work on our Discord community, we'll be happy to help.",
                    "Simple doesn't mean sloppy. Review it dozens of times so there are no misspellings, typos, broken links, non-matching colours, misaligned sections."
                }
            },
            new Project
            {
                Id = 23,
                Title = "Resume",
                IconUrl = "icons8-resume-512.png",
                Description = "The last step before start applying for jobs. Let’s build a nice resume before hit the Apply button",
                Area = Area.StartApplying,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now that you have a portfolio of projects, you need a resume. A portfolio sometimes won’t be looked at, but the resume definitely will. This is the piece where you’ll summarise the relevant information about you, and i5 will ultimately dictate if your application will move forward or not."
                    }
                },
                Requirements = new List<string>
                {
                    "Use a template",
                    "You should have links to your github and your portfolio",
                    "If you think a picture will favour you, use it, but please smile",
                    "Your resume should have a maximum of two pages. But only have two pages if you have that much relevant experience",
                    "Your resume should contain a cover letter and be different for each organisation"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://www.theodinproject.com/lessons/node-path-getting-hired-building-your-resume'>The Odin Project: Build your Resume</a>",
                    "<a href='https://www.freecodecamp.org/news/how-to-write-a-resume-with-example/'>Free Code Camp: How to Write a Resume</a>",
                    "<a href='https://enhancv.com/resume-examples/entry-level-software-engineer/'>Entry Level Resume Examples</a>",
                     "<a href='https://resumegenius.com/resume-samples/entry-level-software-engineer-resume'>Resume Builder</a>",
                    "<a href='https://www.youtube.com/watch?v=17YZBH_qtmg'>Resume Tips (Youtube)</a>"
                },
                ResourcesConclusion = "These should suffice, but you can always do your own research, there’s plenty of material online on how to build a nice entry level software engineering resume.  😁 Below is the resume that I landed me my first tech job. Bear in mind the project links might be broken since hosting full stack apps on Azure isn’t free and I might have removed them. ",
                Tips = new List<string>
                {
                    "Don't send resumes machine-gun style. Tailor each application to each job. Write a different cover letter to each application. Do that after looking at their website and if possible, address your future manager by name. Write about something specific you saw in the website, which means you actually took your time to prepare this application. Careless applications have less chance of succeeding.",
                    "Your resume has to look professional. Get a template, even if you need to buy one (it's cheap). There are infinite resume template services online. Remember, you're selling your brand, your resume has to look nice.",
                    "Include mostly relevant experience. I included my experience as a Salsa teacher not because I thought my moves would help the company, but because I wanted to let them know I had experience leading and communicating with large groups of people.",
                    "Track your applications. You can build an MVC app for this (in fact, we will have a project for that soon), but it can be as simple as an excel spreadsheet with a few columns: Date, Name Of the Company, Outcome. And whatever else you think is relevant."
                },
                Screenshots = new List<string>
                {
                    "Resume_PabloSouza.jpg"
                }
            },
            new Project
            {
                Id = 24,
                Title = "Water Drinking Logger",
                IconUrl = "icons8-drinking-96.png",
                Description = "Build your first full-stack app with ASP.NET C# Razor Pages and ADO.NET",
                Area = Area.MVC,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to the world of Razor Pages! Razor pages is a “newer, simplified web application programming model. It removes much of the ceremony of ASP.NET MVC by adopting a file-based routing approach. Each Razor Pages file found under the Pages directory equates to an endpoint.” There’s a lot of discussion in the .NET world about the pros and cons of Razor Pages vs MVC. Here at the C# Academy, we will learn both design patterns, so you’re better prepared to get your first job and excel at it. "
                    },
                    new Paragraph
                    {
                        Body="Another advantage of learning Razor Pages is that it uses Razor syntax, which is the same solution .NET uses for MVC and Blazor. That means that your knowledge will be applied in many different pieces of technology. If you’re hired to work with C#, you’ll most likely work with one of these at some stage. Even companies that use front-end frameworks such as Vue, React or Angular have applications using .NET front-end solutions as part of their domain. Your knowledge will go a long way."
                    }
                },
                RequirementsIntro = "The requirements for this project are different than the ones in the Console Area. From what I’ve seen, being out in the world trying to figure out, as a beginner in C#, how Razor Pages or MVC work, just using the documentation or free tutorials, is very frustrating. As much as I like Microsoft’s documentation in general, it doesn’t seem to satisfy the needs of many beginners. For that reason, I put together a video tutorial with the basics of Razor Pages. As usual, it’s project-based. The business model should be very similar to our first couple of console Apps, the Habit Tracker, and the Coding Tracker. But in this video I’ll walk you through the project step-by-step. You might consider this “hand-holding”, and it is. But once you learn these basics, we will have project where you’ll have to implement different business cases using Razor Pages and MVC. Don’t worry, I won’t hold your hand for too  long. 😁",
                Requirements = new List<string>
                {
                    "Follow the Razor Project Tutorial in the link provided, creating a list of steps with notes you think are important.",
                    "Recreate the project, with a different business case. Track something different and use different styling. Time to be creative!!"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://bit.ly/3uVRjfM'>Razor Syntax Docs</a>",
                    "<a href='https://bit.ly/3MeGF9V'>Razor Pages Docs</a>",
                    "<a href='https://bit.ly/36uivZR'>Learn Razor Pages</a>",
                     "<a href='https://bit.ly/393KNLD'>Javascript Crash Course</a>",
                    "<a href='https://bit.ly/3rD1Bj7'>Bootstrap Crash Course</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/architecture/porting-existing-aspnet-apps/comparing-razor-pages-aspnet-mvc'>Microsoft: Razor Pages vs MVC</a>",
                    "<a href='https://stackoverflow.com/questions/48121928/asp-net-core-razor-pages-vs-full-mvc-core'>Stack Overflow: Razor Pages vs MVC</a>"
                },
                Tips = new List<string>
                {
                    "Don't forget to have all of your code on Github, ALWAYS",
                    "You'll come across many different files and pieces of code you've never seen. Study each one carefully, use the links in the resources area. You can find thorough explanations about each little piece of the code searching online."
                },
                Challenges = new List<string>
                {
                    "What if you want to allow split numbers? I.e. 2.25 cups of water, how would you change your data types?",
                    "How about letting the user decide between standard measures (big bottle, bottle, glass)",
                    "What if you want to have another habit being tracked in the same project? The limit to what you can create is the limit of your imagination."
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Video Tutorial",
                        ImgUrl= "icons8-video-tutorial-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/iIFAKW21d-4"
                            }
                        }
                    }
                }
            },
            new Project
            {
                Id = 25,
                Title = "Movies",
                IconUrl = "icons8-movie-512.png",
                Description = "Build your first full-stack app with ASP.NET C# MVC and Entity Framework",
                Area = Area.MVC,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to the wonderful world of MVC.  You should be excited! Model-View-Controller is one of the most widely used design patterns in web development. The concepts you’ll learn apply to any language or framework, not just C#. You’ll be thinking MVC on a daily basis when you get a job."
                    },
                    new Paragraph
                    {
                        Body=".NET provides three solutions for full-stack development: Razor Pages, Blazor and MVC. MVC is by far the most popular and it’s widely used in enterprise. While Blazor is gaining ground and more .NET teams are starting to use it, chances are you’ll have to write and/or maintain MVC code at some stage in your career."
                    },
                    new Paragraph
                    {
                        Body="For this initial tutorial we’ll be using the official documentation. Its MVC tutorial does a very good job at explaining the basic concepts. There will be a bit of hand-holding at first. You’ll be using .NET’s “scaffolding” <b><i><u>(Scaffolding in ASP.NET Core is a technique used to generate code at design time to support a number of common application scenarios when working with Entity Framework Core)</u></i></b>, which is necessary given the slight complexity of the project, but if you pay attention to each line of code, by the end of this project you’ll have a good grasp of MVC basics."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application to manage information about movies.",
                    "Users should be able to Add, Delete, Update and Read from a database, using website as the front-end.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "There needs to be a search functionality where I can search movies by name.",
                    "You should use SQL Server, not SQLite"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio'>Microsoft Docs MVC Tutorial</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/architecture/porting-existing-aspnet-apps/comparing-razor-pages-aspnet-mvc'>Microsoft Docs MVC vs Razor Pages</a>",
                    "<a href='https://stackoverflow.com/questions/48121928/asp-net-core-razor-pages-vs-full-mvc-core'>Stack Overflow: MVC vs Razor Pages</a>",
                     "<a href='https://www.guru99.com/mvc-vs-mvvm.html'>MVC vs MVVM Article</a>"
                },
                ResourcesConclusion = "Notice that there’s a lot of talk about Razor Pages, MVVM, MVC. Those topics can be confusing. Give these texts a good read and reach out on Discord if it doesn’t make sense. And remember, Google is your best friend! 😁",
                Tips = new List<string>
                {
                    "In the Microsoft Docs MVC Tutorial, the first three chapters contain a simple controller with a view, for basic understanding of .NET MVC. Don't skip that part. But the actual Movie App code starts on Part 4.",
                    "Read every single line of the tutorial. Don't rush through the steps.",
                    "Once you're finished, push your final version to Github, create a new repository and do it again, step-by-step, there's a lot going on in MVC, and one time isn't enough.",
                    "I strongly recommend you make notes to help you connect the dots in ASP.NET MVC. There are lots of little details to learn and it will serve as a reference for your future MVC projects."
                },
                Challenges = new List<string>
                {
                    "Scaffolding means you're using .NET's tools to generate code for you. A very nice challenge for better retention would be to recreate the same project without scaffolding. It's ok if you copy and paste chunks of code from the original project. It will still be helpful.",
                    "Once you've done it twice, do it a third time, but with different data. Intead of movies, countries? Cars? Music? Sports? Anything, it will further cement your knowledge.",
                    "\r\nAdd one or more separate areas to the app. TV Series, for example. Or music. You'd have to create different pages for each, and a link in the nav bar."
                }
            },
            new Project
            {
                Id = 26,
                Title = "Todo List",
                IconUrl = "todo.png",
                Description = "Build your first MVC application with C#, Razor Syntax, Javascript and Bootstrap",
                Area = Area.MVC,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In our previous project we dove into Microsoft’s Beginner MVC Tutorial and created our first full-stack application. In that app, each action has a dedicated page. However, what happens if I want to have a single page application and not open a new page every time they want to create, delete or update their data? This is what we will build now."
                    },
                    new Paragraph
                    {
                        Body="Again we will be using a tutorial from the official documentation, where we will be introduced to “Minimal APIs” and working with “Fetch API”, which will help us with moving data around asynchronously "
                    },
                    new Paragraph
                    {
                        Body="Get ready, now it really gets fun! You’ll finish this project understanding how C#, Javascript and Bootstrap work together.  From here, the limit to what you’ll be able to build will be close to the limit of your imagination. 😁"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should manage a todo list.",
                    "Users should be able to Add, Delete, Update and Read from a database, using a SPA (single-page application). The user should never be redirected to a new page.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "You don't need a navigation bar. No menu is necessary since you'll only have one page.",
                    "Once you execute any operation, the todo-list needs to be updated accordingly.",
                    "Your data model is only one table with to-dos. You. might be tempted to create more complex data-models (categories of todos for example) but avoid that for now. We're focusing on the front-end."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio'>MVC + Fetch API + Minimal API Tutorial</a>",
                    "<a href='https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch'>Fetch API Docs</a>",
                    "<a href='https://www.youtube.com/watch?v=hdI2bqOjy3c'>Javascript crash course on Youtube</a>",
                    "<a href='https://www.youtube.com/watch?v=Oive66jrwBs'>Fetch API crash course on Youtube</a>"
                },
                Tips = new List<string>
                {
                    "When learning to connect JS to your MVC App, take a step-by-step approach: First try to call a simple alert, then try to send data to and from the controller into JS.",
                    "Use console.log() to help you debug your javascript code when working together with C#.",
                    "The tutorial uses Mongo DB as data solution. If it adds too much confusion, just connect your App to a SQL server or SQLite solution instead. The focus now is on the front-end, so where the data is coming from shouldn't matter."
                }
            },
            new Project
            {
                Id = 27,
                Title = "Budget",
                IconUrl = "icons8-budget-512.png",
                Description = "Build a personal finance app with multiple related tables in the back-end",
                Area = Area.MVC,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Personal finances apps are very useful for learning web development. They’ll force you to handle many data types: Dates, strings, decimals, integers, to mention the most basic. They’ll also challenge your front-end skills with heavy user interaction through forms and data-tables."
                    },
                    new Paragraph
                    {
                        Body="In terms of database design, they give you the chance to create interesting structures, such as one-to-many and many-to-many relationships between tables, which in turn expands pushes the boundaries of our knowledge of SQL and Entity Framework. So let’s build a budget app to expand on our MVC knowledge with a slightly more complex piece of software."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record personal finance transactions.",
                    "You should have two linked tables: Transaction and Category.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "Each transaction MUST have a category and if you delete a category all it's transactions should be deleted.",
                    "You should use SQL Server, not SQLite.",
                    "You should have a search functionality where I can search transactions by name",
                    "You should have a filter functionality, so I can show transactions per category and per date.",
                    "You need to use modals to insert, delete and update transactions and categories. These operations shouldn't be done in a different page."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",

                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key'>Relationships in EF Core</a>",
                    "<a href='https://www.learnentityframeworkcore.com/configuration/one-to-many-relationship-configuration'>One-To-Many Relationship in EF Core</a>",
                    "<a href='https://www.youtube.com/watch?v=eHT6G912po0'>One-To-Many Relationship in EF Core on Youtube</a>"
                },
                Tips = new List<string>
                {
                    "Don't forget validation! Your form shouldn't allow the user to input negatives or strings as a transaction value. Data annotations on your model are one way to go.",
                    "Have separate controllers for Categories and Transactions."
                }
            },
            new Project
            {
                Id = 28,
                Title = "Authentication and Authorization",
                IconUrl = "icons8-safe-ok-480.png",
                Description = "Learn how to secure your app with ASP.NET Core Identity",
                Area = Area.MVC,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="So far we’ve learned how to build a full-stack app but we’ll never be able to deploy it without securing it first. If you publish a form that calls a database and allow anyone to use it, it will eventually be found by bots designed to find database vulnerabilities. If you pay for your data server as you use it, the result will be a massive bill. Believe me, I learned the hard way. 😁"
                    },
                    new Paragraph
                    {
                        Body="In principle, creating a custom authentication and authorisation system is fairly easy. You can even try yourself. Simply create an ‘user’ table with login and password and create a registration form that will insert a new user and a login form that will check the user input against that table. Then if the user is logged in you can allow him to view your page. If not, redirect him to the login/registration area.."
                    },
                    new Paragraph
                    {
                        Body = "The reality is a little bit more complex though, since any real A&A system will need to support functionalities like changing password, managing an account, confirming a registration, just to name a few. ASP.NET Identity offers scaffolding for dozens of these operations, shipping fully-functioning front and back-end solutions. And they’re customisable too! Let’s see how it works. "
                    }
                },
                Requirements = new List<string>
                {
                    "In this project, you'll have two tasks.",
                    "In a first moment you'll create a new Web App project with Identity as part of it.",
                    "In a second moment you'll scaffold Identity into the Movies App you created before.",
                    "You need to use Entity Framework, raw SQL isn't allowed."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio'>Introduction to Identity</a>",
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0&tabs=visual-studio'>Scaffolding Identity into Existing App</a>"
                },
                Tips = new List<string>
                {
                    "After wiring Identity up, you need to apply it to the controller you want to protect."
                }
            },
            new Project
            {
                Id = 29,
                Title = "Ecommerce",
                IconUrl = "icons8-online-store-64.png",
                Description = "Build a fully functioning ecommerce for products of your choice",
                Area = Area.MVC,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Ecommerce is one of the most common business types of application in web development. Job offers in this area will only keep increasing as more people have access to the internet and get comfortable shopping online. If you’ve done all projects in our program, you have most of the tools necessary to launch a fully-functional ecommerce that can be deployed to production."
                    },
                    new Paragraph
                    {
                        Body="The main difference in this project will be the increased complexity, since we will have multiple views, classes and tables in the database. This project will be divided in two. In the first one we will build the app with support for registration and login. Then we will have another project where we will introduce an administration page where employees will be able to add products and manage users. And to finalise we will deploy it on Azure. There’s a fair bit of work to do, so let’s get started! "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where users will buy products. You can choose what type of product.",
                    "It should contain a layout file with a navbar that will be displayed in every page.",
                    "It should contain a Home Page with Feature Products and a search functionality where users can search products by category.",
                    "It should contain a page for each product, with an Add To Cart Button.",
                    "It should contain a mini-cart button page where users can check their order. Users can only view their mini-cart if they're logged in.",
                    "It should contain registration, login, logout and password resetting pages/functionalities.",
                    "You should have an orders controller, that will be triggered when users place an order.",
                    "The starter project needs to be MVC Web App.",
                    "You need to use the repository pattern.",
                    "For data access, you should use Dapper.",
                    "You should use ASP.NET Core Identity to handle users",
                    "Once an user places an order, show a message saying the order has been processed and send a simple e-mail to the address used in registration"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio'>Intro to Identity</a>",
                    "<a href='https://www.learndapper.com/'>Dapper Tutorial</a>"
                },
                Tips = new List<string>
                {
                    "Before starting, plan the design of your application: What will the flow of data be like?",
                    "Don't worry about styling at first. Make sure everything works, then come back and make it look good.",
                    "This is a big project. It might be easier to build each part at a time: First, the main page with all products, then the product detail, then the mini-cart and so on",
                    "You will need the following tables: Users, products, orders. An user can have multiple orders. An order can't exist without one user and at least one product. A product can be in multiple orders. How are you going to plan the foreign keys that will link these tables?"
                }
            },
            new Project
            {
                Id = 30,
                Title = "E-Commerce Admin",
                IconUrl = "icons8-admin-512.png",
                Description = "Build an administration page for the e-commerce you build in project 6, using Asp.NET Role-based Authentication",
                Area = Area.MVC,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="A very common requirement in ecommerce is the development of an Administration Page. In a company, it’s almost always non-developers who will be adding products, managing employess, stock allocations, just to mention a few of the most common tasks. In that case, the business will need not only a customer facing e-commerce website, but an administration that will be accessible only by authorised personnel. "
                    },
                    new Paragraph
                    {
                        Body="This project is a continuation of the previous one, where you built an e-commerce of your choice. This time you’ll allow authorised users to update the products of your page (and anything else you think it’s worth being managed by an admin page). "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application that will serve as an administration page for an e-commerce.",
                    "You should use ASP.NET Identity with Roles to manage authorisation.",
                    "You should have three roles: User, Admin and Director",
                    "The director will be the one who will add the employees and with Administration powers.",
                    "The employees profiles need to contain a picture that will be uploaded by the directors.",
                    "The user shouldn't have access to the admin area",
                    "This projects should be contained in the E-commerce solution you've developed before.",
                    "When an user tries to access a forbidden area, present a clear error message"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",

                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-6.0'>Microsoft Docs – Role-Based Authorisation in .NET</a>",
                    "<a href='https://www.yogihosting.com/aspnet-core-identity-roles/'>Article: How to work with Roles in ASP.NET Core Identityl</a>",
                    "<a href='https://procodeguide.com/programming/aspnet-core-identity-roles-authorization/'>Article: ASP.NET Core Identity Roles based Authorization</a>"
                },
            },
            new Project
            {
                Id = 31,
                Title = "Tour of Heroes",
                IconUrl = "icons8-superwoman-480.png",
                Description = "Learn the basics of Angular by building a purely front-end app using the documentation",
                Area = Area.Angular,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to the world of front-end frameworks! You should be excited, you’re about to take your first step in learning one of most required technologies of our time. Most job applications require knowledge of a Javascript front-end solutions, tried and tested tools for building scalable, interactive web applications."
                    },
                    new Paragraph
                    {
                        Body="The good news is that if you’ve been through the MVC area, learning the basics of Angular will be a breeze. It does most of the heavy lifting that Javascript does in MVC, so you’ll be building sooner than you imagine. "
                    },
                    new Paragraph
                    {
                        Body="Make no mistake, Angular and React are massive. There’s a fair amount of complexity and the learning curve is definitely steep. So be patient, you won’t become an expert overnight. However, these frameworks are very welcoming to beginners. Building simple apps with them is somewhat straightforward, so be careful not to get caught into unnecessary complexities early on. Let’s build a few simple apps first. And what better way to start than building a Coffee app? ☕🤩"
                    }
                },
                RequirementsIntro="From Angular’s documentation page: 'The <i>Tour of Heroes</i> application that you build helps a staffing agency manage its stable of heroes. The application has many of the features you’d expect to find in any data-driven application. The finished application acquires and displays a list of heroes, edits a selected hero’s detail, and navigates among different views of heroic data.'",
                Requirements = new List<string>
                {
                    "This project has only one requirement: You should complete the \"Tour of Heroes\" app in Angular's documentation page."
                },
                ResourcesIntro = "All you need for this project is the beginners tutorial provided by the Angular team:",

                Resources = new List<string>
                {
                    "<a href='https://angular.io/tutorial'>Angular Docs: Tour of Heroes Beginner’s Tutorial</a>"
                },
                ResourcesConclusion = "Since this is your first Angular project, we will keep it very simple. There won’t be any .NET or C# this time, you’ll focus on Angular only. And the documentation will provide everything you need for your first app.",
                Tips = new List<string>
                {
                    "Don't rush, everything here will be new, so take your time to understand each line of code.",
                    "Make notes. Here are three types of notes you can take: 1. Lists of steps to build things; 2. Concepts you're first learning about; 3. Things you find interesting and likely to use in the future. Keep your notes short.",
                    "If you feel you didn't retain much, you could redo the app and/or modify it and/or create a different app based on the gained knowledge. Tweaking projects goes a long way for content retention."
                }
            },
            new Project
            {
                Id = 32,
                Title = "Coffee Tracker",
                IconUrl = "icons8-coffee-mug-128.png",
                Description = "Track your coffee consumption with a C# Web Api and Angular",
                Area = Area.Angular,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now that you’re familiar with Angular, let’s combine it with .NET! And what a powerful combination that is. The limit of what you can build using these two is only the limit of your imagination. We will be creating two separate applications: An Angular front-end and a C# Web Api. The front-end will call the api, similarly to what you’ve done before in our Shifts Logger project."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record your consumption of coffee.",
                    "You can choose something else to track, in case you're not a coffee person.",
                    "You should create two projects: A.NET WebApi and an Angular app.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "You should have a filter functionality, so I can show records per type and / or date.",
                    "Your database should have a single 'Records' table.The objective is to focus on Angular, so we should avoid the complexities of relational data.",
                    "You CANNOT use Angular Material."

                },
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio'>Microsoft Docs: Web Api</a>",
                    "<a href='https://angular.io/tutorial'>Angular Docs: Tour of Heroes Beginner’s Tutorial</a>",
                    "<a href='https://www.itsolutionstuff.com/post/angular-12-crud-application-tutorial-exampleexample.html'>Angular CRUD Tutorial</a>",
                    "<a href='https://www.youtube.com/watch?v=S5dzfuh3t8U'>Angular + C# Web Api Youtube Tutorial</a>",
                    "<a href='https://stackoverflow.com/questions/65082452/cors-is-not-working-with-net-core-api-and-angular-frontend'>Dealing With CORS (Cross Origin Resource Sharing)</a>"
                },
                ResourcesConclusion = "Since this is your first full-stack Angular project, make sure you look up everything you don’t know. Try not to let any keyword, method or concept left-behind. This is the moment to build your foundation. And don’t forget to reach out on Discord if you have questions!",
                Tips = new List<string>
                {
                    "Your main objective is to call your API from the Angular App. Everything else is just moving data around and styling.",
                    "There are two ways to approach the construction of this app: Finishing the API first and then building the UI, or building each method end-to-end (ex: GetAllRecords method in the back-end plus list of records in the front-end). Choose one and stick to it.",
                    "Don't use Angular Material (a library for styling) in this project. Angular alone can be challenging enough and adding a rich library early on might overwhelm you. Also, you'll appreciate Angular Material more if you built applications without it first."
                }
            },
            new Project
            {
                Id = 33,
                Title = "Sleep Tracker",
                IconUrl = "icons8-sleeping-512.png",
                Description = "Build on your Angular foundation with an app to log and generate reports about your sleep",
                Area = Area.Angular,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Your second Angular project has the objective of solidifying the knowledge you gained from the Coffee Tracker. Even though Angular is a beginner-friendly framework, it’s still a lot to take in, and if you’re coming from a C# background, there are a few things to get used to. But don’t worry! You will still be challenged. We’re building on the first project with two extra challenges."
                    },
                     new Paragraph
                    {
                        Body="In this project you’ll log data about your sleep, either manually inputting your time in bed or using a timer to automatically log it. Dealing with time is always a challenge and great practice. Also, you’ll be using Angular Material, a powerful UI component library ubiquitous in enterprise Angular projects. This is a massive library that does take some time to learn, but once you master it, it becomes extremely easy to build interesting and great-looking UI components. You’ll be saying goodbye to Bootstrap! "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record sleep time.",
                    "You should create two projects: A .NET WebApi and an Angular app.",
                    "You need to use Angular Material.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "You should have a filter functionality, so I can show records per type and / or date.",
                    "Your database should have a single 'Records' table.The objective is to focus on Angular, so we should avoid the complexities of relational data.",
                    "This app needs to have a timer that will log your sleep once stopped and saved.",
                    "Users should also be able to input their sleep time using a form.",
                    "Your list of sleep records should have pagination, so you're not loading all records every time you visualise the list."


                },
                Resources = new List<string>
                {
                    "<a href='https://material.angular.io/'>Angular Material Docs</a>",
                    "<a href='https://material.angular.io/guide/getting-started'>Getting Started With Angular Material</a>",
                    "<a href='https://www.youtube.com/watch?v=jGbP620NahE'>Angular Material CRUD Tutorial</a>"
                },
                ResourcesConclusion = "Angular Material can be tricky at first, but trust us, you’ll learn to love it and once you master it, you will never look back. But as always, reach out in our Discord Community if you get stuck!",
                Tips = new List<string>
                {
                    "When building your timer, I suggest you have a pause, play, stop and save buttons for better user experience.",
                    "If you get stuck implementing Angular Material in your project, take a step back and build a couple of simple purely front-end projects from Youtube tutorials."

                }
            },
            new Project
            {
                Id = 34,
                Title = "Quiz Game",
                IconUrl = "icons8-quiz-game-contestants-480.png",
                Description = "Build a highly interactive Quiz Game with Angular and Angular Material",
                Area = Area.Angular,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now you’ve completed two projects with Angular and hopefully you’re starting to get comfortable with it. This next project will have a slightly more complex design and will stimulate your creativity while reinforcing your knowledge of Angular. We’ll once again practice a more complex data relationship scenario. This project will keep you busy for a while, but you’ll learn a lot from it. "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you will create and play quiz games.",
                    "You should create two projects: A .NET WebApi and an Angular app.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose only use Entity Framework, no other ORM is allowed.",
                    "Your database should have three tables: Question, Quiz, Game.",
                    "A question needs to have a Quiz associated with it, hence a foreign key is needed.",
                    "A game needs to have a Quiz associated with it, hence a foreign key is needed.",
                    "If a quiz is deleted, all questions and games associated with it need to be deleted.",
                    "You need to use pagination, which means you can't show any lists or tables longer than the height of the screen.",
                    "You need to use Angular Material"
                },
                Resources = new List<string>
                {
                    "<a href='https://blog.devart.com/types-of-relationships-in-sql-server-database.html#:~:text=So%2C%20what%20is%20one%2Dto,one%20record%20in%20table%201.'>Relationships in SQL</a>",
                    "<a href='https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx'>One-to-many relationship Entity Framework</a>",
                    "<a href='https://material.angular.io/components/table/overview'>Tables and Pagination in Angular Material</a>"
                },
                ResourcesIntro = "The resourced from the previous Angular projects can be used for the completion of this project, plus these: ",
                Tips = new List<string>
                {
                    "This project has loose design requirements, so search for quiz game designs on Google for inspiration, when you're planning your app.",
                    "Try to work with a couple of UI elements you haven't used before, for practice. In Angular Material's Documentation, if you click on Components, you'll see a large list of components on the left side of the screen. Grab one or two that you think can fit the project.",
                    "This is a very strong portfolio project, so make sure you pay attention to details, don't leave any stone unturned and ask for feedback in our community.",
                    "Take your project a step further by creating interesting features such as: A timer for your games, which the users can use. Or reports such as: games played per week, favourite games, etc. Let your creativity loose!"

                }
            },
            new Project
            {
                Id = 35,
                Title = "Tic-Tac-Toe",
                IconUrl = "icons8-tic-tak-toe-cross-and-circle-matrix-game-with-work-strategy-concept-384.png",
                Description = "A very simple project to easy you into with this rich framework. You’ll be consuming an Api of your choice",
                Area = Area.React,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to React, the most popular front-end framework in the world. The hype isn’t unwarranted. React is truly a joy to work with. Building components and managing application state is made extremely easy by these guys and you’ll be building very cool apps in no time with this tool."
                    },
                    new Paragraph
                    {
                        Body="Right now (August 2022), I still consider a better idea to learn Angular first, since there are way too many React developers out there competing for jobs. And The C# Academy doesn’t have an opinion about which one is better. They’re both great, and ideally, we should learn both. And of course, if in your area there are more React jobs than Angular, go for it!"
                    },
                    new Paragraph
                    {
                        Body="In this project, you’ll build a Tic-tac-toe game with the help of the React Docs tutorial. I know, one of my pet-peeves is the insistence in learning through a useless game, particularly Tic-tac-toe. That doesn’t resemble anything you’ll work with in real life. "
                    },
                    new Paragraph
                    {
                        Body = "However, I have to admit, it’s a great tutorial. Truly beginner friendly. And it does have an interesting feature that lets you back previous moves. With this tutorial, you’ll be ready to jump into more interesting stuff right away."
                    }
                },
                RequirementsIntro = "This project has only one requirement. You’ll build a Tic-Tac-Toe game following React’s documentation. The objective at this stage isn’t to modify it or do anything fancy with it. Right now all you need to do is learn the basics. And there’s a lot to learn. So stick to the tutorial and take your time studying each line of code.",

                Resources = new List<string>
                {
                    "<a href='https://reactjs.org/tutorial/tutorial.html'>React Tic-Tac-Toe Tutorial</a>",
                    "<a href='https://reactjs.org/docs/getting-started.html'>React Documentation</a>",
                    "<a href='https://codersera.com/blog/why-learning-reactjs-makes-sense-in-2020/'>Article: Why Learn React in 2022?</a>"
                },
                ResourcesConclusion = "Since this is your first React project, make sure you look up everything you don’t know. Try not to let any keyword, method or concept left-behind. This is the moment to build your foundation. And don’t forget to reach out on Discord if you have questions!\r\n\r\nHere’s my github repository for this project, where you can find branches for each stage of the development of this game. To navigate through the branches, choose from the dropdown as per the picture below: ",
                Tips = new List<string>
                {
                    "Take your time to study each word in the code. This isn't time to rush, but to learn at a slow pace, with patience.",
                    "Take notes, write diagrams. React has completely new concepts to us such as hooks and state management and drawing can be very helpful.",
                    "Once your app is complete, I strongly suggest you redo it and try to add some styling. If you're confused after your first go, it's crucial you go back and start from scratch.",
                    "If you want to take it a step further you could try to build another game. Sudoku? Checkers?"
                }
            },
            new Project
            {
                Id = 36,
                Title = "Call an External API",
                IconUrl = "icons8-baby-app-96.png",
                Description = "Build a simple Get Endpoint with .NET and fetch data from it using React",
                Area = Area.React,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Congratulations! You’ve finished your first React App. It was probably easy. After all, React’s documentation is excellent. It’s at the same time thorough but easy to follow. So let’s complicate things a little. "
                    },
                     new Paragraph
                    {
                        Body="It’s time for you to combine a React App to a .NET WebAPI. Since this is the first time you’re doing it, we will keep it simple. We will only be showing data coming from the API via Get requests. This will reinforce what you’ve learned in the first app, and will exercise your creativity. Oh, and by the way, we will also be training .NET Web Apis again. Let’s go!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should present data coming from a .NET WebAPI using React.",
                    "Your application can only have GET requests.",
                    "You cannot use AXIOS to fetch the data, you have to use JS Fetch API",
                    "You should create an API of your choice, with a model representing a single table.",
                    "One of the properties of your API's model should be imageUrl, with a link to pictures that will be shown by the react app.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "Your app needs to have a list of records and a page to visualise an individual record.",
                    "Your app should show a 'Loading Data...' message while the request hasn't been completed.",
                    "If there's a server error, the user should be informed."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.freecodecamp.org/news/fetch-data-react/'>How to fetch data with React</a>",
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0'>Enabling CORS (Cross Origin Resource Sharing) in .NET Web API</a>",
                    "<a href='https://stackoverflow.com/questions/65082452/cors-is-not-working-with-net-core-api-and-angular-frontend'>Dealing With CORS errors (Stack Overflow)</a>",
                    "<a href='https://www.youtube.com/watch?v=DTBta08fXGU'>Handling Fetch API errors in React</a>",
                },
                ResourcesConclusion = "Connecting to an API using Fetch JS is incredibly easy. But chances are you’ll find a cross-origin error. Don’t forget to visit these links to solve it. ",
                Tips = new List<string>
                {
                    "This app should be relatively easy to build. Try not to over complicate it.",
                    "If you want to add extra features, think of: pagination, filters and the ability to create a list of 'favourite' records.",
                    "Think of a project that has plenty of good images online and keep it simple. Examples: Dogs, Cats, Movies, Cars, Athletes, Singers, Bands, Drinks.",
                    "<a href='https://github.com/public-apis/public-apis'>Another variation of this project would be to call a public api. Click to view a massive list.</a>"
                }
            },
            new Project
            {
                Id = 37,
                Title = "Shopping List",
                IconUrl = "icons8-shopping-list-512.png",
                Description = "Build your first full CRUD app with React, calling a .NET Web API",
                Area = Area.React,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="It’s time to advance in your React knowledge by creating a full CRUD application with a .NET backend. This time you’ll also need a full CRUD .NET web API, so you get some extra practice in that as well. We’re recommending you stick to the basics and don’t use Redux (a popular state management library used in React). Its learning curve can be quite steep and you’re still taking baby-steps in React. You’ll also have a greater appreciation of Redux if make a few apps without it first. "
                    }
                },
                Requirements = new List<string>
                {
                    "This is a CRUD Shopping List App with React and .NET Web API .",
                    "Users should be able to cross items from the shopping-list without deleting them. You can use a IsPickedUp boolean for that.",
                    "You should create two projects: A .NET WebApi and a React app.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "To keep it simple, don't create a project that allows multiple shopping lists.",
                    "Your database should have a single \"ShoppingListItems\" table. The objective is to focus on React, so we should avoid the complexities of relational data.",
                    "You CANNOT use Axios or Redux."


                },
                ResourcesIntro = "The resources from the previous projects will be helpful in the completion of this project, plus this tutorial:",

                Resources = new List<string>
                {
                    "<a href='https://www.freecodecamp.org/news/fetch-data-react/'>Crud React Tutorial Example</a>"
                },
                ResourcesConclusion = "This is just an example of a tutorial where a React app uses it’s inbuilt Http client to call an api. However React is one of the most popular libraries out there, so feel free to search for other examples. ",
                Tips = new List<string>
                {
                    "Start by building the complete CRUD .NET Webapi",
                    "In your second step, make sure you can call the get method from the API using React. Once the data is flowing between apps, everything else becomes easier."
                }
            },
            new Project
            {
                Id = 38,
                Title = "Friends Manager",
                IconUrl = "icons8-friend-512.png",
                Description = "Build an app that will help you monitor and cultivate your friendships managing state with Redux",
                Area = Area.React,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In this project we will manage our friendships. This won’t be just a contact book. It will be an app where we will keep track of the people we consider REAL friends. The main objective is to keep track of how much attention we’re giving to our friends. So not only we will have our friends details, but also data about our frequency of communication with them. "
                    },
                     new Paragraph
                    {
                        Body="We will be dealing with a more advanced way of managing state in React. We will use Redux to keep a central state management system so you don’t have to pass it around using props and pointer functions. Managing state with props is ok for small projects, but as soon as our system have more than a few layers, it can quickly get messy. Managing state in a central location will reduce the amount of code and make debugging much easier. Not to mention the visualization of the data pathways within our app. "
                    }
                },
                Requirements = new List<string>
                {
                    "In this app you'll keep data about the friendships you want to cultivate.",
                    "You can choose which properties you want to have in your \"Friend\" model, except that you need to have a \"LastContactDate\" and a \"LastContactType\" and a \"Desired Contact Frequency\" properties",
                    "You're also required to have a \"Category\" table, which will be linked to your \"Friends\" table by a foreign key.",
                    "Users should be able to easily visualize the friends that are getting the least attention (i.e. Last contact date has been longer than desired contact frequency)",
                    "When adding a new friend, the form should contain a dropdown with the Category.",
                    "You need to use Redux for state management.",
                    "You need to handle validation and server errors."
                },
                ResourcesIntro = "Adding onto the resources of our previous React projects, you’ll need to find out how to use Redux:",
                Resources = new List<string>
                {
                    "<a href='https://react-redux.js.org/tutorials/quick-start'>React-Redux Quick Guide</a>",
                    "<a href='https://www.valentinog.com/blog/redux/'>Beginners Redux: Complete Guide</a>",
                    "<a href='https://www.youtube.com/watch?v=hXpYQqykORU'>React Redux Crud App (Youtube).</a>"
                },
                ResourcesConclusion = "Angular Material can be tricky at first, but trust us, you’ll learn to love it and once you master it, you will never look back. But as always, reach out in our Discord Community if you get stuck!",
                Tips = new List<string>
                {
                    "You won't find many tutorials of React-Redux with C# Web Api. But with the knowledge of the previous React projects you should be able to setup the required front-end and call a C# server.",
                    "Initially don't worry about styling. Make sure everything is working as intended first and add styles in the end.",
                    "Since you're new to Redux, you might need to create a \"stepping stone\" project where your only focus is to learn redux with a very simple app (i.e. todo list)."
                },
                Challenges = new List<string>
                {
                    "Once this project is done, I highly recommend you create two forks for two different ways of managing state: Context API, and Recoil.",
                    "Find a way to get an e-mail sent to user with warnings such as : You haven't contacted John in 14 days!"
                }
            },
            new Project
            {
                Id = 39,
                Title = "Wardrobe Inventory",
                IconUrl = "icons8-wardrobe-392.png",
                Description = "Get started with Blazor by building an inventory for your clothes. With pictures!",
                Area = Area.Blazor,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to Blazor!! The current .NET solution for web-development that Microsoft created to compete with React (Meta) and Angular (Google). You might be thinking, why learn Blazor where most jobs want React/Angular? And that’s a good point. In fact I wouldn’t start with Blazor in the front-end before knowing one of the big JS frameworks. But once you have one of those covered, having Blazor in your resume might give you the edge you need to land that dream-job. And make no mistake! Even though there are LESS Blazor jobs out there, they definitely exist. And not many people are fighting for them."
                    },
                     new Paragraph
                    {
                        Body="Blazor lets you build user interfaces without using Javascript. Both client and server code is written in C#, allowing you to share code and libraries. It’s just a joy to work with. Up to 2022, there were two types of Blazor projects: Blazor Web Assembly, and Blazor Server. But recently Microsoft creates Blazor Hybrid, which allows you to use Blazor components to build the UI for apps with WPF and most importantly, MAUI. Wow!! Let’s get started??"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should store and retrieve wardrobe data..",
                    "You should use a Blazor Webassembly project.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "Since we'll only have basic CRUD operations, you should use Entity Framework.",
                    "Your database should have a single table. The objective is to focus on learning Blazor, so we should avoid the complexities of relational data.",
                    "Users of your app need to be able to upload pictures of wardrobe items.",
                    "You CAN'T USE Javascript interop. The objective is to stay away from JS, even though it's still possible to use it."
                },
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio'>Microsoft Docs: Blazor</a>",
                    "<a href='https://www.c-sharpcorner.com/article/blazor-what-it-is-why-should-we-use-it/'>Why use Blazor?</a>",
                    "<a href='https://www.c-sharpcorner.com/blogs/create-a-net-6-app-on-blazor-wasm-for-crud-operations-with-ef-core'>Blazor CRUD Tutorial</a>"
                },
                ResourcesConclusion = "Since this is your first Blazor  project, I recommend you first complete the Blazor Todo App from Microsoft Learn. It’s a very simple project that will give you a basic understanding of how Blazor works. And don’t forget to reach out on Discord if you have questions!",
                Tips = new List<string>
                {
                    "You only need a single project. Contrary to using Angular and React, you don't need to create two separate projects, since the front-end end and the back-end will be covered by Blazor.",
                    "In this project, you're not allowed to use Javascript Interop. But a nice challenge after the completion of the project would be to integrate it to your project: <a href='https://docs.microsoft.com/en-us/aspnet/core/blazor/javascript-interoperability/?view=aspnetcore-6.0'>Javascript Interop Explained</a>, <a href='https://www.youtube.com/watch?v=p4MD6ycpQpY'>Javascript Interop Youtube Tutorial</a>"
                }
            },
            new Project
            {
                Id = 40,
                Title = "Memory Game",
                IconUrl = "icons8-memory-512.png",
                Description = "Build a simple memory game where users will train their brain and track results",
                Area = Area.Blazor,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="The objective of this project is to provide extra practice so you can consolidate your knowledge of Blazor. The data model won’t be very complex. But manipulating the state of the UI will be slightly complex. "
                    },
                     new Paragraph
                    {
                        Body="We will build a simple memory game where the users are presented with a group of paired cards facing down and they can turn the cards up to try to match them with their pair. Once a pair is matched, it becomes inactive. The game is finished when all pairs are matched. "
                    }
                },
                Requirements = new List<string>
                {
                    "Your memory game should have a timer.",
                    "Once a game is finished it should record the date it was played and the time it took to finish in a \"games\" table.",
                    "You should have just one level of difficulty.",
                    "Your game should have 9 cards.",
                    "The app should have two main components: the game and the games list.",
                    "You shouldn't need a database for the game functionality. All the information about the cards can be in lists in the code base.",
                    "Since it only requires basic operations, use Entity Framework for recording game history."
                },
                ResourcesConclusion = "You should be able to complete this project with the same resources found in the <a href='https://www.thecsharpacademy.com/wardrobe/'>Blazor Wardrobe Inventory</a> project.",
                Tips = new List<string>
                {
                    "Split the development in three phases: game functionality, games history, styling.",
                    "When developing the functionality, have a simple game with 4 or 6 cards for faster testing.",
                    "During development, use characters on your cards. Bring in icons or images in the styling phase."
                },
                Challenges = new List<string>
                {
                    "Add difficulty levels to your game: more cards.",
                    "Add a game against the clock: How many cards can the user match in a minute?",
                    "Add a search functionality to the games list",
                    "Add a reports area where you'll query the database and show: How many games played per week/month/year and average score"
                }
            },
            new Project
            {
                Id = 41,
                Title = "Food Journal",
                IconUrl = "icons8-ingredients-480.png",
                Description = "Log your food habits in your first CRUD Blazor App",
                Area = Area.Blazor,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In your previous Blazor Apps, you’ve worked with fairly simple data models. The objective of the Food Journal project is to increase complexity with relational data, which always adds complexity to development of forms and collecting the user input. It also adds complexity to filters and report systems. Our goal won’t be to learn extra Blazor Features, but to use what was previously learned with a more challenging business case. So let’s get moving!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application to track meals.",
                    "Your data schema should have at least a \"Meals\" and a \"Foods\" table, in a many-to-many relationship.",
                    "You should have a MealType enumeration (Breakfast, Lunch, Dinner, Snack), which will be recorded in the meals table.",
                    "Your app should have a vibrant color palette.",
                    "There should be a feature that allows the users to quickly record frequent meals.",
                    "There should be a search functionality (per date, per food, per meal type)",
                    "There should be a report feature with queries such as how many times the user had a certain food per period of time."
                },
                Tips = new List<string>
                {
                    "Tracking every meal requires incredible discipline. Your app needs to make recording meals very easy. Make each meal and food a button to make the process very agile.",
                    "If possible use icons to represent the foods, as it makes the app more pleasing to use. You can find excellent icons on icons8.com."
                },
                Challenges = new List<string>
                {
                    "Add macronutrients categorization.",
                    "Add a \"cheat meal\" feature to record how many times the user ate junk food or candies.",
                    "Add goals such as: drinking 20 liters of water in a week, or avoiding chocolate for 7 days.",
                    "To enrich your app, try to fetch food data from a free Api: <a href='https://apilist.fun/category/food'>6 Free Food APIs</a> project."
                }
            },
            new Project
            {
                Id = 42,
                Title = "Sports Statistics",
                IconUrl = "icons8-football-team-480.png",
                Description = "Build an application to track the performance of a sports team in real time",
                Area = Area.Blazor,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="You were hired by a sports club to build a software that will keep track of their teams statistics. They’ve tried several different apps but none was exactly what they wanted so decided to budget for an in-house developer. You’re lucky that your Blazor skills are now soaring and you’re ready to deliver. So far you have learned almost everything needed to fulfil the projects requisites. We will only add the ability to show data charts to help their coaches visualize the players performances. Let’s get started!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application that will track and generate reports about a sports team's performance.",
                    "The app will have a page divided two areas: The UI where the in-game data will be tracked and an area showing the current statistics.",
                    "The app will have a reports area in a different page showing the players statistics across multiple games. Coaches should be able to se detailed players information per game and per season. This area should contain barcharts with the players performance.",
                    "The UI needs to contain a list of players with 5 parameters that will be tracked (i.e. passes, shots, rebounds, blocks, interceptions, in basketball.",
                    "Data should be tracked with the click of a button. (i.e. a rebound button clicked on Dennis Rodman's row will track a rebound at a given time in the game).",
                    "The reports area should be updated immediately upon a button being clicked."
                },
                ResourcesIntro="You should have all skills necessary to complete this project, except for adding charts . Here are a couple of resources to get you started.",
                Resources = new List<string>
                {
                    "<a href='https://www.c-sharpcorner.com/article/learn-to-draw-simple-asp-net-core-blazor-bar-chart-using-canvas-extensions/'>Simple Bar Chart in Blazor</a>",
                    "<a href='https://www.youtube.com/watch?v=ft9t3P1riOM'>High chart in Blazor</a>",
                    "<a href='https://www.youtube.com/watch?v=p4MD6ycpQpY'>Blazor JS Interop (Youtube)</a>"
                },
                Tips = new List<string>
                {
                    "If you haven't used Blazor + JS Interop before this might be a could opportunity to start. You don't need JS for most things in Blazor, but it might come in handy at times. Create a small project to practice it.",
                    "If you get stuck implementing Angular Material in your project, take a step back and build a couple of simple purely front-end projects from Youtube tutorials."
                },
                Challenges = new List<string>
                {
                    "Add the possibility of tracking the area of the playing field where an action happened, with a click on the fields area.",
                    "Add an Admin area where players can be added.",
                    "Add Authentication and Authorization so only logged in users can use the app.",
                    "Add role-based authorization with roles like: \"view only\", \"admin\", and \"superuser\""
                }
            },
            new Project
            {
                Id = 43,
                Title = "Math Game",
                IconUrl = "icons8-maths-376.png",
                Description = "Start your native app development journey building a simple game with the four basic mathematical operations",
                Area = Area.MAUI,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to .NET MAUI (Multi-platform App UI), the cross-platform framework for creating native mobile and desktop apps. Maybe you’ve heard of previous .NET solutions for native apps (Winforms, WPF, WinUI, Xamarin) and you might be wondering: Why MAUI? MAUI is the evolution from all those previous technologies, it’s the framework that has as an objective to provide a one-stop shop for anything todo with build applications in any device. "
                    },
                     new Paragraph
                    {
                        Body="Does that mean it’s not worth to learn those? The answer isn’t very simple. If you need to learn WPF for example for a job, then it’s better to be specific and learn that particular technology. Now for the long run it’s better to learn the latest solution. And the good news is that MAUI uses XAML as a mark-up and is commonly implemented with the MVVM (Model-View-ViewModel) design pattern. They’re both also used in WPF, WinUI and Xamarin, which means that the knowledge is easily transferrable amongst them."
                    },
                     new Paragraph
                    {
                        Body="But enough talk! Let’s build!"
                    }
                },
                Requirements = new List<string>
                {
                    "This application has only one requirement: You'll build a Math Game with MAUI (and no MVVM) with the help of the tutorial below:",
                },
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/dotnet/maui/what-is-maui'>What is .NET MAUI?</a>",
                    "<a href='https://stackoverflow.com/questions/62729794/what-is-maui-and-what-are-differences-between-maui-and-xamarin'>Maui vs Xamarin</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/maui/xaml/'>What is XAML?</a>",
                    "<a href='https://www.guru99.com/mvc-vs-mvvm.html'>MVC vs MVVM</a>"
                },
                ResourcesIntro = "Each video in the tutorial has many links in the description area. Here are some resources you can read before getting started:",
                Tips = new List<string>
                {
                    "If you've done any full-stack Web Dev, you'll be surprised with how easy the C# code is to develop a basic MAUI App. Your biggest challenge here will be to learn XAML. Make sure you don't rush through that.",
                    "Make a checklist of steps for the completion of the tutorial, along with a list of issues you encountered. Once you're done, repeat the project going through the lists.",
                    "Once you went through the project twice, tweak it with slightly different functionality and style."
                },
                Challenges = new List<string>
                {
                    "Try to implement levels of difficulty.",
                    "Add a timer to track how long the user takes to finish the game.",
                    "Add a function that let's the user pick the number of questions.",
                    "Create a 'Random Game' option where the players will be presented with questions from random operations"
                }
            },
            new Project
            {
                Id = 44,
                Title = "Books to Read",
                IconUrl = "icons8-bookshelf-512.png",
                Description = "Build an app to keep track of reading activity using the MVVM pattern",
                Area = Area.MAUI,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="The objective of our second MAUI project is to get acquainted with the MVVM (Model-View-ViewModel) design pattern. The main purpose of MVVM is separation of concerns. With MVVM we will end up with smaller classes with less code. Using this pattern or not is a matter of personal style, but it’s widely adopted in enterprise because of the complexity of the domain. A large code base without separation of concerns in mind quickly turns into spaghetti: code that is less maintainable and testable. Smaller classes and methods with clear responsibility mean they’re easier to test. "
                    },
                     new Paragraph
                    {
                        Body="It does take a while to get used to MVVM, though. And it’s perfectly ok to feel lost at first. The learning curve can be steep, especially after doing so many projects using MVC. A mindset shift is needed. However it will pay off. MVVM is also used in Blazor and the previous .NET native solutions (WPF, Xamarin, WinUI), so this knowledge won’t be restricted to MAUI projects."
                    }
                },
                Requirements = new List<string>
                {
                    "As a preparation for this project, you should complete the Todo List tutorial by James Montemagno (link in the resources area)",
                    "This is a very simple app where you'll record data about books you want to read.",
                    "It should be similar to a todo list, but just for books.",
                    "Users should be able to perform all CRUD operations against the database.",
                    "To keep things simple and focus on MVVM, you'll have just one \"books\" table.",
                    "You should use the MVVM pattern.",
                    "You should use SQLite."


                },
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=Hh279ES_FNQ&list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY'>Dotnet Maui for Beginners.</a>",
                    "<a href='https://stackoverflow.com/questions/2653096/why-use-mvvm'>Why Use MVVM?</a>"
                },
                ResourcesIntro = "With the Math’s Game project, you learned the basics of MAUI and XAML. Now you’ll need to add a design pattern to that knowledge. For that we will get the help of the most knowledgeable MAUI instructor out there: James Montemagno. Initially, you’ll follow his Beginners MAUI tutorial, where you’ll build a Todo List App with MVVM.",
                Tips = new List<string>
                {
                    "The Books Management app can be almost identical to the Todo List project by James Montemagno, with just a few tweaks.",
                    "Take your time learning MVVM. Understand every line of the code. Google everything you don't know. Write diagrams, make notes and lists."
                },
                Challenges = new List<string>
                {
                    "Add a \"photo\" property to the book detail. It will contain an URL to a picture of the book's cover.",
                    "Expand on the project fetching and using data from a books API.",
                    "Create a search functionality where I can query for titles or dates of books previously read (and whatever other filters you can think of).",
                    "Create a \"Reading now\" functionality where you can track your progress in a book you're currently reading"
                }
            },
            new Project
            {
                Id = 45,
                Title = "Monkeys Data",
                IconUrl = "icons8-see-no-evil-monkey-256.png",
                Description = "Build an advanced Mobile UI to present data about Monkeys, using Geolocation to show which monkey is closest to you",
                Area = Area.MAUI,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Learning the MVVM pattern can be quite overwhelming, especially if you’re new to XAML and MAUI, so in this project we will get more MVVM practice while practicing our XAML skills and using native features for mobile apps. We will get help from James Montemagno, the amazing Microsoft Instructor focused on all things XAML. It’s a long tutorial but as always James makes it really easy to follow and enjoy. So let’s not waste any time!"
                    },
                     new Paragraph
                    {
                        Body="In this project you’ll log data about your sleep, either manually inputting your time in bed or using a timer to automatically log it. Dealing with time is always a challenge and great practice. Also, you’ll be using Angular Material, a powerful UI component library ubiquitous in enterprise Angular projects. This is a massive library that does take some time to learn, but once you master it, it becomes extremely easy to build interesting and great-looking UI components. You’ll be saying goodbye to Bootstrap! "
                    }
                },
                Requirements = new List<string>
                {
                    "This project has only one requirement: Follow and complete <a href='https://www.youtube.com/watch?v=DuNLR_NJv8U'>James Montemagno's Monkeys App Tutorial.</a>"
                },
                Challenges = new List<string>
                {
                    "Implement a function to add new Monkeys.",
                    "Create another app based on this tutorial but a different business case and styling."
                }
            },
            new Project
            {
                Id = 46,
                Title = "Warehouse Admin",
                IconUrl = "icons8-warehouse-512.png",
                Description = "Track warehouse operations using a complex data model with Maui",
                Area = Area.MAUI,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In this project you’ll be using the knowledge from the three previous MAUI projects to create a Warehouse Management System, a common business case in enterprise applications, where it’s critical to maintain accurate data about logistical operations. We will aim to give the user interface a clean “corporate” look and generate various types of reports using a complex data system."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an app that will manage warehouse data about a multi-store retail business of your choice.",
                    "Your data schema will contain the following tables: Products, Stores, Employees, WarehouseSlot, Items, ItemMovements.",
                    "Users need to know where a product is at any given time.",
                    "Products can be in transit from store to warehouse and vice-versa.",
                    "Every time a product is in movement, a new record needs to be added in the \"ItemMovement\" table. Every itemMovement needs to have two employess associated with it. One in the shipping end and one in the receiving end.",
                    "An Item is an instance of a product. Products are unique, but there can be multiple items of the same product.",
                    "A warehouse slot needs to contain at least an \"Isle\" and a \"Slot Number\" columns.",
                    "Users should be able to see a history of item movements."
                },
                Tips = new List<string>
                {
                    "Layer the creation of your project: Start with showing a list products showing how many items are available in the inventory.",
                    "Then add the stores and show how many items are available per store. Start with only two stores to keep things simple.",
                    "Then add the item movements and so on.",
                    "This is a project that require some level of planning, especially in regards to data schema, but don't overdo it, you'll only understand some of the requirements as you start coding"
                },
                Challenges = new List<string>
                {
                    "Add authentication and authorization so that only logged in users are able to use the app",
                    "Add role-base authentication, with super users that are able to add products, stores, items and employees.",
                    "Create a detail page for each entity (i.e. click on an employee will show all its details and history of item movements",
                    "Expand the data schema with Customers and Orders table where you'll track sales(Warning: this adds tremendous complexity)",
                    "Feeling adventurous? Implement your app in a mobile device and use a barcode scanner to make handling of items faster."
                }
            },
            new Project
            {
                Id = 47,
                Title = "Deploying a Simple App",
                IconUrl = "icons8-web-392.png",
                Description = "Start with Azure creating an account and deploying a simple app without a database",
                Area = Area.Azure,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In this day and age it’s absolutely essential to have experience with cloud-computing. The “cloud” allows us to access software and data from anywhere at any time, powered by the internet. These technologies have spread very fast amongst big companies since the mid-2000s and now they’re ubiquitous in organizations of all sizes. That means experience with cloud-computing is a requirement in the majority of programming jobs ads. The biggest player in cloud-computing is AWS (from Amazon), with 32% of market share (as of 2020), against Azure’s 20%. And it’s totally ok to choose AWS as your cloud-provider, but we’re sticking to Azure since it’s Microsoft’s solution and it integrates seamlessly with .NET’s tools."
                    },
                     new Paragraph
                    {
                        Body="The amount of services offered by cloud companies is enormous and ever-growing. It’s easy to get lost. The good news is that we don’t need to know too much to declare we “have experience with it”. Basically we need to be able to deploy static websites and full stack apps connected to a database and handle authentication. "
                    },
                     new Paragraph
                     {
                         Body="In the C# Academy, the cloud area is initially split in four projects. In the first we will learn how to deploy a simple app with no database back-end, just to get familiar with Azure Dashboard and integration with VS2022. In the second, we will expand on this knowledge by adding a SQL Server, which can be slightly more complexity. And on the third we will deploy a .NET Web API along with a React front-end, a very common stack in enterprise. As a bonus, we will learn the basics of Azure Functions, “a serverless solution that allows you to write less code, maintain less infrastructure, and save on costs”. So let’s jump into it!"
                     }
                },
                Requirements = new List<string>
                {
                    "This project has only one requirement: To publish a .NET Web App To Azure.",
                    "You can choose any type of .NET app: Razor Pages, MVC or Blazor.",
                    "You can use an existing app, provided it doesn't need a database connection.",
                    "You won't need authentication or authorization.",
                    "You should publish your app to an 'Azure App Service'."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.investopedia.com/terms/c/cloud-computing.asp'>Cloud Computing Overview</a>",
                    "<a href='https://learn.microsoft.com/en-us/training/paths/microsoft-azure-fundamentals-describe-cloud-concepts/'>Microsoft Azure Fundamentals</a>",
                    "<a href='https://account.microsoft.com/account?lang=en-hk'>Creating a Microsoft Account</a>",
                    "<a href='https://azure.microsoft.com/en-us/free/'>Creating an Azure Account</a>",
                    "<a href='http://shorturl.at/blo34'>Azure Deployment</a>"
                },
                ResourcesIntro = "There’s a lot to learn in Azure and it’s easy to get lost. At this stage we suggest you read about Azure to get some context and then get into the specifics of how to deploy an app:",
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Video Tutorial",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Provided you have a Microsoft and and Azure accounts (see links above in case you don’t), you can follow this super quick tutorial where you’ll learn how to deploy to Azure using Visual Studio 2022: "
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/TcghUb1NPCw"
                            }
                        }
                    }
                }
            },
            new Project
            {
                Id = 48,
                Title = "Deploying a full-stack .NET app",
                IconUrl = "icons8-full-stack-512.png",
                Description = "Deploy a crud app from the .NET ecosystem along with a database server",
                Area = Area.Azure,
            },
            new Project
            {
                Id = 49,
                Title = "Deploy a full-stack .NET + JS Framework app",
                IconUrl = "icons8-website-468.png",
                Description = "Deploy a full-stack app using a JS framework along with a .NET Web API",
                Area = Area.Azure
            },
            new Project
            {
                Id = 50,
                Title = "Azure Functions",
                IconUrl = "icons8-cloud-connection-480.png",
                Description = "Get started with serverless computing creating backend services directly on the cloud",
                Area = Area.Azure
            }
        };
    }
}
