using System;
using System.Collections.Generic;

namespace COMP003A.FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //control navigation

            List<IntakeRecord> records = new List<IntakeRecord>();
            bool exit = false;
            int nextId = 1;
            
            //Menu loop
            while (!exit)
            {
                Console.WriteLine("\n~~College Intake System~~");
                Console.WriteLine("1. Add New Record");
                Console.WriteLine("2. View All Records");
                Console.WriteLine("3. Search Records");
                Console.WriteLine("4. Display Data Summary");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                string input = Console.ReadLine();
                int choice = 0;

                //Menu Input Validation
                //TryCatch numeric input
                try
                {
                    choice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }

                //Verification for choice within range
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Out of Range input. Please enter 1-5.");
                }

                // switch choice for inputs 1-5
                switch (choice)
                {
                    case 1:
                        AddRecord(records, ref nextId);
                        break;

                    case 2:
                        ViewAll(records);
                        break;

                    case 3:
                        Search(records);
                        break;

                    case 4:
                        ShowSummary(records);
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Program ended.");
                        break;
                }
            }
        }
        //Add record
        static void AddRecord(List<IntakeRecord> records, ref int nextId)
        {
            Console.Write("First name: ");
            string first = Console.ReadLine();
            
            Console.Write("Last name: ");
            string last = Console.ReadLine();
            
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.Write("GPA: ");
            double gpa = double.Parse(Console.ReadLine());
            
            Console.Write("SAT Score: ");
            int sat = int.Parse(Console.ReadLine());
            
            Console.Write("ACT Score: ");
            int act = int.Parse(Console.ReadLine());

            Console.Write("Application type (Freshman or Transfer): ");
            string type = Console.ReadLine();
            
            Console.Write("First Generation (true or false): ");
            bool firstGen = bool.Parse(Console.ReadLine());
            
            Console.Write("Veteran (true or false): ");
            bool vet = bool.Parse(Console.ReadLine());

            IntakeRecord record = new IntakeRecord(
                nextId,
                first,
                last,
                age,
                gpa,
                sat,
                act,
                type,
                firstGen,
                vet);
            
            records.Add(record);
            nextId++;
            
            Console.WriteLine("Record added.");
        }
        
        //View All using foreach
        static void ViewAll(List<IntakeRecord> records)
        {
            if (records.Count == 0)
            {
                Console.WriteLine("No Records Available");
                return;
            }

            foreach (IntakeRecord record in records)
            {
                record.DisplayRecord();
            }
        }
        // Search Records
        static void Search(List<IntakeRecord> records)
        {
            Console.Write("Enter name for search: ");
            string name = Console.ReadLine();

            bool found = false;

            foreach (IntakeRecord record in records)
            {
                if (record.MatchesName(name))
                {
                    record.DisplayRecord();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No matching records");
            }
        }
        //Summary
        static void ShowSummary(List<IntakeRecord> records)
        {
            if (records.Count == 0)
            {
                Console.WriteLine("No data for summary.");
                return;
            }

            double totalGpa = 0;
            double highestGpa = 0;

            foreach (IntakeRecord record in records)
            {
                totalGpa += record.GPA;

                if (record.GPA > highestGpa)
                {
                    highestGpa = record.GPA;
                }
            }

            double average = totalGpa / records.Count;
            
            Console.WriteLine($"Average GPA: {average}");
            Console.WriteLine($"Highest GPA: {highestGpa}");
        }
    }
}