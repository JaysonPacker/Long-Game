namespace ConsoleApp6
{

    using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Varibles
            string userName;
            int score = 0;


            // ask for username
            Console.WriteLine("Please Enter Your username");
            userName = Console.ReadLine();

            // make fileinfo ogject with username.txt as the math
            FileInfo userFile = new FileInfo($@"C:\Users\Jayson P\source\repos\ConsoleApp6\userInfo\{userName}.txt");

            // if there exist a file with the username use the score from that
            if (userFile.Exists)
            { 
                Console.WriteLine("File Exists");
            }else // if not make a file with that username  
            {

            }

            // check for key pressed and incrment score and display it 

            // if the key is enter call endgame


            Console.WriteLine("Hello, World!");
        }
    }
}
