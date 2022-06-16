using System;
using System.Collections.Generic;

namespace ADT_ASM_2
{
    public class Buffer
    {
        public int NumberOfQueue;              // This property tracking how many queue is use to
                                               // To transfer message      
        private Queue<string> messageBuffer;   // Create private queue for string to store message

        public Buffer()   // Buffer Constructor
        {
            messageBuffer = new Queue<string>(25);   // When Buffer is created is create
        }                                               // A queue with size 25

        public void SendMessage(string m)    // Send Massage function
        {
            NumberOfQueue = 0;
            while (m.Length >= 1)          // When Message function contain higher than 1 characters
            {
                string sub1;
                if (m.Length < 10)        //  If the message contain lower than 10 characters
                {
                    messageBuffer.Enqueue(m);    // The Buffer will use 1 queue size 10 to contain message
                    m = string.Empty;            // Empty the string after enqueue to stop while loop
                    NumberOfQueue++;             // increase number of used queue counter
                    break;                       // Break the loop
                }
                sub1 = m.Substring(0, 10);   // If the message contain more than 10 characters
                                                          // cut first 10 character put into sb1
                messageBuffer.Enqueue(sub1);              // enqueue sb1 to queue
                string sub2 = m.Substring(10);            // cut the rest of the message put into sb2
                m = sub2;                                 // assigned sub2 to initial string m to continue
                                                          // Separate message into substring contain 10 characters
                if (m.Length < 10)                        // If the sub2 contain lower than 10 characters.
                {
                    messageBuffer.Enqueue(sub2);          // We use 1 queue size 10 to contain 
                    m = string.Empty;                     // Empty the string after enqueue to stop while loop
                    NumberOfQueue++;                      // increase number of used queue counter
                }
                NumberOfQueue++;                          // increase number of used queue counter
            }
        }   

        public void ReceiveMessage()       // Receive Message function
        {
            string s2 = "";                  // Create empty string s2 to contain the message
            int i = messageBuffer.Size;      // assign i equal to size of queue
            while (messageBuffer.Size != 0)  // Create while loop to concatenate the message
            {
                string output = messageBuffer.Dequeue();  // each time Dequeue will be stored in output
                s2 += output;                        // Concatenate output string into s2 string
                i--;                                 // Decrease the size to 1
                if (i == 0)                          // Break out condition
                {
                    break;
                }
            }
            Console.WriteLine(s2);          // Print out condition.
        }             
    }
}