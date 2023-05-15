using System.Collections;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "Science":
                    Console.WriteLine("I love dissecting frogs");
                    break;

                case "Math":
                    Console.WriteLine("Math makes my head hurt");
                    break;

                case "History":
                    Console.WriteLine("History repeats itself");
                    break;

                case "Culianry":
                    Console.WriteLine("Dont burn the kitchen down");
                    break;

                case "Economics":
                    Console.WriteLine("Lets get rich");
                    break;
            }



        }
    }
}