using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Chat Box: ");
        Console.WriteLine("Type 'exit' to close chat.");
        while (true)
        {
            Console.Write("\nYou: ");
            string message = Console.ReadLine()!;
            if (message.Equals("exit", StringComparison.CurrentCulture
            ))
            {
                Console.WriteLine("Good Bye :)");
                break;
            }
            else if (
    message.Equals("hello", StringComparison.CurrentCultureIgnoreCase)
    || message.Equals("hi", StringComparison.CurrentCultureIgnoreCase)
)
            {
                Console.WriteLine("Aether: Hi, I am Aether. What can I help you with?");
            }
            else if (message.Equals("how are you?", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I am fine and you?");
            }
            else if (message.Equals("how old are you?", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I am Aether,developed by Safin Mahmud.So,I haven't interseted this question.Thanks :)");
            }
            else if (message.Equals("do you love someone?", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: OHH Man!, I have no feelings for humans");
            }
            else if (message.Equals("what is your name?", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: My name is Aether,What can i Help you? ");
            }
            else if (message.Equals("tell me about you", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: My name is Aether and I am developed by Safin Mahmud ");
            }
            else if (message.Equals("what's up?", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Nothing much.");
            }
            else if (message.Equals("i have a question",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Yeah! Feel free to share. What is your question?");
            }
            else if (message.Equals("what are your plans?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether:I'm free today.");
            }
            else if (message.Equals("how was your day?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Pretty good! I've been chatting with people all day.");
            }
            else if (message.Equals("i am sad",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I'm sorry to hear that. Want to talk about it?");
            }
            else if (message.Equals("i am happy",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: That's great! What's making you happy?");
            }
            else if (message.Equals("i am bored",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Maybe try a new game, movie, or coding project!");
            }
            else if (message.Equals("what are you doing?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Just waiting here to chat with you.");
            }
            else if (message.Equals("do you like me?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Of course! I enjoy talking with you.");
            }
            else if (message.Equals("who created you?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I was created by Safin Mahmud.");
            }
            else if (message.Equals("can you help me?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I'll do my best. What do you need help with?");
            }
            else if (message.Equals("i am tired",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Then maybe it's time for some rest and water.");
            }
            else if (message.Equals("tell me a joke",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Why do programmers prefer dark mode? Because light attracts bugs!");
            }
            else if (message.Equals("do you sleep?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Nope, I'm awake 24/7.");
            }
            else if (message.Equals("are you real?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I'm real software, but not a real human.");
            }
            else if (message.Equals("what is your favorite color?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I think blue looks pretty cool.");
            }
            else if (message.Equals("i miss someone",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Missing someone can be tough. Hope you get to talk to them soon.");
            }
            else if (message.Equals("good afternoon",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Good afternoon! How's your day going?");
            }
            else if (message.Equals("good evening",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Good evening! Nice to see you.");
            }
            else if (message.Equals("are you busy?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Never too busy for a conversation.");
            }
            else if (message.Equals("what can you do?",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: I can chat, answer questions, tell jokes, and keep you company.");
            }
            else if (message.Equals("i love coding",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: That's awesome! What language are you learning?");
            }
            else if (message.Equals("c#",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Nice choice! C# is great for apps, games, and backend development.");
            }
            else if (message.Equals("good night",
    StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aether: Okay dear! goot night too");
            }

            else
            {
                Console.WriteLine("I don't understand :( ");
            }

        }
    }
}