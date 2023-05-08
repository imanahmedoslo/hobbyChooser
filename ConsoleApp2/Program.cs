using System.Reflection.PortableExecutable;

namespace ConsoleApp2
{
   
    internal class Program
    {
       static string[] hobbies = { "magic", "fencing", "eating cake", "swimming" };
        static void Main(string[] args)
        {
            giveMeAHobby();
        }
        static int chooseARandomNumber()
        {
            var random = new Random();
           return random.Next(0, hobbies.Length);
        }
        static void giveMeAHobby()
        {
            string message;
            int whileInt = 0;
            do
            {
                Console.WriteLine("who needs a new hobby?");
                string nome = Console.ReadLine();



                message = $"{nome} now loves {hobbies[chooseARandomNumber()]}";
                Console.WriteLine(message);
                whileInt++;


            } while( whileInt < hobbies.Length);
           

        }
    }
}