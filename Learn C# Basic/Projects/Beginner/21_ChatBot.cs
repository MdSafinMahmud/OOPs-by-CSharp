using System;
using System.Threading;
// using System.Speech.Synthesis;
class Program
{
    static string userName = "";
    static void AetherReply(string reply)
    {
        Console.Write("Aether is typing");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(400);
            Console.Write(".");
        }
        Console.WriteLine();
        Console.WriteLine($"Aether:{reply}");

    }
    static void Main(string[] args)
    {
        Console.WriteLine("\n\tHellow! I'm Aether :) \n\tYour personal ChatBOT.");
        Console.WriteLine("\tPlease say good bye,When your task is complete.");
        Console.WriteLine("\nWhat's your name?");
        userName = Console.ReadLine()!;
        Console.WriteLine("Hey " + userName + ",whats'up");
        while (true)
        {
            Console.Write("\nYou: ");
            string message = Console.ReadLine()!;
            if (message.Equals("good bye", StringComparison.CurrentCulture
            ))
            {
                AetherReply("Good Bye :) Take care yourself...\n" + userName);
                break;
            }
            else if (
    message.Equals("hello", StringComparison.CurrentCultureIgnoreCase)
    || message.Equals("hi", StringComparison.CurrentCultureIgnoreCase)
)
            {
                AetherReply("Hi,I am Aether. What can I help you with?");

            }
            else if (message.Equals("how are you?", StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I am fine and you?");
            }
            else if (message.Equals("i am fine", StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Sounds good!.What's your plan today?");
            }

            else if (message.Equals("how old are you?", StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I am Aether,developed by Safin Mahmud.So,I haven't interseted this question.Thanks :)");
            }
            else if (message.Equals("do you love someone?", StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("OHH Man!, I have no feelings for humans");
            }
            else if (message.Equals("what is your name?", StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("My name is Aether,What can i Help you? ");
            }
            else if (message.Equals("tell me about you", StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("My name is Aether and I am developed by Safin Mahmud.");
            }
            else if (message.Equals("whats up?", StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Nothing much.");
            }
            else if (message.Equals("i have a question",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Yeah! Feel free to share. What is your question?");
            }
            else if (message.Equals("what are your plans?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I'm free today.");
            }
            else if (message.Equals("how was your day?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Pretty good! I've been chatting with people all day.");
            }
            else if (message.Equals("i am sad",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I'm sorry to hear that. Want to talk about it?");
            }
            else if (message.Equals("i am happy",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("That's great! What's making you happy?");
            }
            else if (message.Equals("i am bored",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Maybe try a new game, movie, or coding project!");
            }
            else if (message.Equals("what are you doing?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Just waiting here to chat with you.");
            }
            else if (message.Equals("do you like me?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Of course! I enjoy talking with you.");
            }
            else if (message.Equals("who created you?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I was created by Safin Mahmud.");
            }
            else if (message.Equals("can you help me?",
    StringComparison.CurrentCultureIgnoreCase) || message.Equals("do you help me?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I'll do my best. What do you need help with?");
            }
            else if (message.Equals("i am tired",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Then maybe it's time for some rest and water.");
            }
            else if (message.Equals("tell me a joke",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Why do programmers prefer dark mode? Because light attracts bugs!");
            }
            else if (message.Equals("do you sleep?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Nope, I'm awake 24/7.");
            }
            else if (message.Equals("are you real?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I'm real software, but not a real human.");
            }
            else if (message.Equals("what is your favorite color?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I think blue looks pretty cool.");
            }
            else if (message.Equals("i miss someone",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Missing someone can be tough. Hope you get to talk to them soon.");
            }
            else if (message.Equals("good afternoon",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Good afternoon! How's your day going?");
            }
            else if (message.Equals("good evening",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Good evening! Nice to see you.");
            }
            else if (message.Equals("are you busy?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Never too busy for a conversation.");
            }
            else if (message.Equals("what can you do?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("I can chat, answer questions, tell jokes, and keep you company.");
            }
            else if (message.Equals("i love coding",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("That's awesome! What language are you learning?");
            }
            else if (message.Equals("c#",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Nice choice! C# is great for apps, games, and backend development.");
            }
            else if (message.Equals("good morning",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Good morning dear!. What's your plan today?");
            }
            else if (message.Equals("good night",
    StringComparison.CurrentCultureIgnoreCase))
            {
                AetherReply("Okay dear! good night too");
            }
            else
            {
                AetherReply("I don't understand :( ");
            }
        }
    }
}