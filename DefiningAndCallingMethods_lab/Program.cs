﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningAndCallingMethods_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }        
    }
}
