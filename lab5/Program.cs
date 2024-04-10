using lab5;
using System;

class Program
{
    static void Main(string[] args)
    {
        Head head = new Head(25);
        Console.WriteLine($"Зарплата керiвника: {head.Salary()}");
        Console.WriteLine();

        Manager manager = new Manager(5);
        Console.WriteLine($"Зарплата менеджера: {manager.Salary()}");
        Console.WriteLine();

        Engineer engineer = new Engineer(7);
        Console.WriteLine($"Зарплата iнженера: {engineer.Salary()}");
        engineer.PrintVacationDays();
        Console.WriteLine();

        Mechanic mechanic = new Mechanic(15);
        Console.WriteLine($"Зарплата механiка: {mechanic.Salary()}");
        Console.WriteLine();

        ArchitectEngineer architectEngineer = new ArchitectEngineer(8);
        Console.WriteLine($"Зарплата архiтектора-iнженера: {architectEngineer.Salary()}");
        Console.WriteLine();

        Executive executive = new Executive(4);
        Console.WriteLine($"Зарплата виконавця: {executive.Salary()}");
        Console.WriteLine();

        Worker worker = new Worker(1);
        Console.WriteLine($"Зарплата управлiнця: {worker.Salary()}");
        Console.WriteLine();

        manager.AddSubordinate(engineer);
        manager.AddSubordinate(mechanic);
        manager.AddSubordinate(architectEngineer);
        manager.AddSubordinate(executive);
        manager.AddSubordinate(worker);
        manager.AddSubordinate(head);

        Console.WriteLine($"Кількість підлеглих менеджера {manager.CountSubordinatesWithLowerSalary()}");

    }
}
