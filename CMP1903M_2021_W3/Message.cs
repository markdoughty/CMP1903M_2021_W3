using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CMP1903M_2021_W3
{
    class Message
    {
        //private field
        private string _message;

        //public property hiding private field
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }

        //read the message to encrypt from a file
        public void readMessageFromFile(string filename)
        {
            
        }

        //read the message to encrypt from input
        public void readMessageFromInput()
        {
            Console.WriteLine("Enter your message to encode...");
            message = Console.ReadLine();
        }
       
    }
}
