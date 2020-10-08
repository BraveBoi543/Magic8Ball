using System;

namespace Magic8Ball
{
    class Program
    {
        //First Magic 8 Ball is nothing more than an rng machine
        //So we are going to create an object that will basically be a random number
        static Random randomObject = new Random();
        static void Main(string[] args)
        {
            QuestionLoop();
        }
        static String GetQuestionFromUser()
        {
            Console.Write("What question do you have? ");
            string questionString = Console.ReadLine();
            return questionString;
        }
         static void  QuestionLoop()
        {
            while (true)
            {
                string questionString = GetQuestionFromUser();
                int randomNumber = randomObject.Next(4);
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Bad Idea!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("That's A Mystery For The Ages!");
                            break;
                        }
                }
            }
        }
    }
}
