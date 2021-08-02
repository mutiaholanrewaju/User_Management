using System;
using System.Collections.Generic;

namespace UserMgtConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Instantiating the UserQueue class
            UserQueue<string> queue = new UserQueue<string>();
            //Instantiating the UserInterface class
            UserInterface user = new UserInterface();
           
          //Writing to the concole to accepting input from the user 
            Console.WriteLine("User Management System");
            Console.WriteLine("\n Enter your First Name:\n");
            user.FName = Console.ReadLine();
            Console.WriteLine("\n Enter your Last Name:\n");
            user.LName = Console.ReadLine();
            Console.WriteLine("\n Enter your email Address:\n");
            user.email = Console.ReadLine();
            Console.WriteLine("Full Name is : " + user.FName +" " + user.LName + "\nEmail Address: " + user.email);
            
            //Adding the user input to the queue
            queue.Enqueue(user.FName, user.LName, user.email);

            queue.Print();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            //Removing user from the user
            Console.WriteLine(queue.Dequeue() + "Removed");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            queue.Print();

            //Calling the file method
            UserFile.UserToFile();
            UserFile.UsersFromFile();
          }
    }
}
