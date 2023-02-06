namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your favorite school subject?");
            string subject = (Console.ReadLine());
            
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Not bad! Math is decent!");
                    break;
                case "science":
                    Console.WriteLine("Yikes! You must be smart!");
                    break;
                case "history":
                    Console.WriteLine("I see you like to learn about the past! Good stuff!");
                    break;
                case "english":
                    Console.WriteLine("Yuck! Go write an essay on how you can be better than that! C'mon!");
                    break;
                case "music":
                    Console.WriteLine("Nice! Music is one of my favs!");
                    break;
                case "art":
                    Console.WriteLine("Okay Picasso, calm down!");
                    break;
                default:
                    Console.WriteLine("Yawn! Pick something cooler!!");
                    break;

            }
        }
    }
}