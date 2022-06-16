using System;
using System.Threading.Channels;

namespace ADT_ASM_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Buffer buf = new Buffer();                     // Initialize the Buffer
                Console.WriteLine("Input Your message");       // Tell the user input the message
                string input = Console.ReadLine();             // Take the input of the users
                Console.WriteLine("Number of character: " + input.Length);  // Show out to he number of characters
                if (input.Length == 0)  // Check the input is empty and if yes through exception
                {
                    throw new ArgumentOutOfRangeException(nameof(Queue<string>), "No input message");
                }
                else if(input.Length > 250)  // Check the input contain higher than 250 character if yes
                {                            // Through exception
                    throw new ArgumentOutOfRangeException(nameof(Queue<string>), "Message cannot be more than 250");
                }
                buf.SendMessage(input); // Send the input message
                Console.WriteLine("Number of queue use to send message: " + buf.NumberOfQueue); // Print out number of
                                                                                                // queue use to send
                                                                                                // that message
                Console.WriteLine("Message received: ");   // Tell received the message in coming
                buf.ReceiveMessage();  // Print out Received message
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);  // If any exception raise catch it and print out
            }

            Console.ReadLine();
        }
    }
}