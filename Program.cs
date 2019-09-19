using System;

namespace Maxwell_Deliverable3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user what is there name 

                Console.WriteLine("What is your name?");
                Console.WriteLine("");

                // Call to method to greet user

                Greeting ();
            }
            catch
            {
                Console.WriteLine("Please exit the program and try again.");
            }
        }// End of main 

            // Method used to return users name 

            private static string Greeting ()
            {
                 // Declare variable to gather user name 

                 string name =  Console.ReadLine();
                 
                 // Greeting to user 

                 Console.WriteLine(""); 
                 Console.WriteLine("Hello " + name + "!" );

                 // Return users name as a value 

                 return name;
            
            }// End of greeting method 
    }
}
