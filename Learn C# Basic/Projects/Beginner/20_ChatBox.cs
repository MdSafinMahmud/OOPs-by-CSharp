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
                Console.WriteLine("Good Bye!");
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
            else
            {
                Console.WriteLine("I don't understand :( ");
            }

        }

    }
}