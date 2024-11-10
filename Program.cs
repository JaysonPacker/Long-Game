namespace ConsoleApp6
{
    using System;
    using System.IO;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Varibles
            string userName = "unKnown";
            int score = 0;
            string path;
            bool play = true;
            string line;
           

            // ask for username
            Console.WriteLine("Please Enter Your username");
            userName = Console.ReadLine();
            // make path to {username}.txt
            path = $@"..\userInfo\{userName}.txt";
            // if the file exites the object opens it if not a new f
            FileStream userFile = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(userFile);
            // if there exist a file with the username use the score from that
            line = sr.ReadLine();
            if (line != null)
            {               
                score = Int32.Parse(sr.ReadLine());
                Console.WriteLine("File Exists");
                sr.Close();
            }

            Console.WriteLine($"Your Current score: {score}");
            Console.WriteLine("Let the game begin n/");
            Console.WriteLine("Press Enter to end it");

            while (play)
            {               
            // check for key pressed 
                if (Console.ReadKey().Key == ConsoleKey.Enter)// stop game if user preses enter
                {
                    play = false;
                    Console.WriteLine($"Game over {userName}. Final Score {score}");
                }
                else// incrment score and display it
                {
                    score++;
                    Console.WriteLine($" Your new Score: {score} ");
                }
            }
            userFile.Close();
              // write the score to the file
            StreamWriter sw = new StreamWriter(path,false);
            sw.WriteLine("Score");
            sw.Write(score);
            sw.Close();
        }
    }
}
