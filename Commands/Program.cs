using System;
using System.Collections.Generic;
using System.Text;

namespace Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connection oConnection = new Connection();

            oConnection.ConnectionHandler();
            Console.ReadLine();
        }
    }
}