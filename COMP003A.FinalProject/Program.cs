using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace COMP003A.FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //control navigation

            List<IntakeRecord> records = new List<IntakeRecord>();
            bool exit = false;
            int nextID = 1;
            
            //Menu loop
            while (!exit)
            {
                Console.WriteLine("\n~~College Intake System~~");
                Console.WriteLine("1. Add New Record");
                Console.WriteLine("2. Search Records");
                Console.WriteLine("3. View All Records");
                Console.WriteLine("4. Display Data Summary");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                string input = Console.ReadLine();
                int choice = 0;
            }
        }
    }
}