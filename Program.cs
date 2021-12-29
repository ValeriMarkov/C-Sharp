using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework___Task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title=("Door Logger");

            Console.WriteLine("Please, after entering a name, press any key ('ESCAPE' excluded), so that you can enter another one.\n" +
                "If you want to exit program, press 'ESCAPE' button\n");

            // Bellow i create the people we will use for the log file

            Dictionary<string, bool> person = new Dictionary<string, bool>();
            person.Add("Rudolf", false);
            person.Add("Jolly", false);
            person.Add("Valeri", false);

            // -------------------------------------------------------

            ConsoleKeyInfo input;
            do          //i make a infinity loop to re-run the code, the condition to end it is at the bottom
            {


                if (!File.Exists("log.txt"))
                {
                    File.Create("log.txt").Close();   //Creating the log file
                }

                Console.Write("Enter persons name to enter/leave the building: ");
                string callName = Console.ReadLine();


                if (person.ContainsKey(callName))    //i specify if the pre made names, match the ones entered by the user
                {
                    if (person[callName] == false)   //when false, it means the person is not in the building
                    {
                        person[callName] = true;     //then we make it true, so that next time he's name is written, will be to exit
                        File.AppendAllLines("log.txt", new string[] { callName + " entered" });
                    }
                    else
                    {
                        person[callName] = false;    //here i make it false again, to repeat the enter/exit cycle
                        File.AppendAllLines("log.txt", new string[] { callName + " exited" });
                    }
                }

                else
                {
                    Console.WriteLine("Invalid person. Please use a valid name: ");   //if user enter's name, which isn't on the list
                }


                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);  //condition to stop the infinity loop and end program (press "ESCAPE" button)

        }
    }
}