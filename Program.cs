﻿using csharp_enum_worker.Entities;
using csharp_enum_worker.Entities.Enums;

namespace csharp_enum_worker;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter departament's name: ");
        string depName = Console.ReadLine();
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine());

        Departament dept = new Departament(depName); 
        Worker worker = new Worker(name, level, baseSalary, dept);

        Console.Write("How many contracts to this worker? ");
        int numContracts = int.Parse(Console.ReadLine());


        for (int i = 1; i < numContracts; i++){
            Console.WriteLine($"Enter #{i} contracts data: ");
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine());
            Console.WriteLine("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine()); 

            HourContract contract = new HourContract(date, valuePerHour, hours); 
            worker.AddContract(contract);
        } 
    }
}