using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{  
    public class Manager : IEmployee
    {
        public int ExperienceYears { get; }
        public int VacationDaysPerYear => 50;
        protected int SubordinateCount { get; private set; }

        public Manager(int experienceYears)
        {
            ExperienceYears = experienceYears;
        }
        public int Salary()
        {         
            return 18000 + ExperienceYears * 1000; 
        }

        public void Vacation()
        {
            Console.WriteLine("У менеджера відпустка");
        }

        public void DayOff()
        {
            Console.WriteLine("У менеджера вихідний");
        }
        public virtual void AddSubordinate(IEmployee subordinate)
        {
            if (subordinate.Salary() < Salary())
            {
                SubordinateCount++;
            }
        }

        public int CountSubordinatesWithLowerSalary()
        {
            return SubordinateCount;
        }

    }

    public class Engineer : IEmployee
    {
        public int ExperienceYears { get; }
        public int VacationDaysPerYear { get; }

        public Engineer(int experienceYears)
        {
            ExperienceYears = experienceYears;
            VacationDaysPerYear = CalculateVacationDays();
        }
        public int Salary()
        {
            return 10000 + ExperienceYears * 1000;
        }
        public void Vacation()
        {
            Console.WriteLine("У інженера відпустка");
        }

        public void DayOff()
        {
            Console.WriteLine("У iнженера вихiдний");
        }

        public void PrintVacationDays()
        {
            Console.WriteLine($"У iнженера {VacationDaysPerYear} вихiдних у роцi");
        }

        private int CalculateVacationDays()
        {
            return 35;
        }
    }

    public class Head : IEmployee 
    {
        public int ExperienceYears { get; }
        public int VacationDaysPerYear => 40;

        public Head(int experienceYears)
        {
            ExperienceYears = experienceYears;
        }
        public int Salary()
        {
            return 20000 + ExperienceYears * 1000;
        }

        public void Vacation()
        {
            Console.WriteLine("У керiвника відпустка");
        }

        public void DayOff()
        {
            Console.WriteLine("У керiвника вихідний");
        }
    }


    public class Mechanic : IEmployee
    {
        public int ExperienceYears { get; }
        public int VacationDaysPerYear => 50;

        public Mechanic(int experienceYears)
        {
            ExperienceYears = experienceYears;
        }
        public int Salary()
        {
            return 4500 + ExperienceYears * 1000;
        }

        public void Vacation()
        {
            Console.WriteLine("У механіка відпустка");
        }

        public void DayOff()
        {
            Console.WriteLine("У механіка вихідний");
        }
    }

    public class ArchitectEngineer : IEmployee
    {
        public int ExperienceYears { get; }
        public int VacationDaysPerYear => 50;

        public ArchitectEngineer(int experienceYears)
        {
            ExperienceYears = experienceYears;
        }
        public int Salary()
        {
            return 3000 + ExperienceYears * 1000;
        }
        public void Vacation()
        {
            Console.WriteLine("У інженера-архітектора відпустка ");
        }

        public void DayOff()
        {
            Console.WriteLine("У інженера-архітектора вихідний");
        }
    }

    public class Executive : IEmployee
    {
        public int ExperienceYears { get; }
        public int VacationDaysPerYear => 50;

        public Executive(int experienceYears)
        {
            ExperienceYears = experienceYears;
        }
        public int Salary()
        {
            return 2000 + ExperienceYears * 1000;
        }
        public void Vacation()
        {
            Console.WriteLine("У виконавця відпустка");
        }

        public void DayOff()
        {
            Console.WriteLine("У виконавця вихідний");
        }
    }

    public class Worker : IEmployee
    {
        public int ExperienceYears { get; }
        public int VacationDaysPerYear => 50;

        public Worker(int experienceYears)
        {
            ExperienceYears = experienceYears;
        }
        public int Salary()
        {
            return 2500 + ExperienceYears * 1000;
        }
        public void Vacation()
        {
            Console.WriteLine("В управлінця відпустка");
        }

        public void DayOff()
        {
            Console.WriteLine("В управлінця вихідний");
        }
    }
}
