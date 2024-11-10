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
            // if the file exites the object opens it if not a new file is created 
            FileStream userFile = new FileStream(path, FileMode.OpenOrCreate);
            // make a stream reader object out of it
            StreamReader sr = new StreamReader(userFile);

            // read the first line of the file which should say score if it already existed
            line = sr.ReadLine();
            //if there exist a line in the file already (i.e it was just made) read read the second line turn it into an int and assign that value to score
            if (line != null)
            {               
                score = Int32.Parse(sr.ReadLine());
                Console.WriteLine("File Exists");
                sr.Close();
            }
        // let the user know the game has begun
            Console.WriteLine($"Your Current score: {score}");
            Console.WriteLine("Let the game begin");
            Console.WriteLine("Press Enter to end it");
            // play controls game and is initialized as true
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
