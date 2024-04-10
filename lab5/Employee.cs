using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public interface IEmployee
    {
        int ExperienceYears { get; }
        int VacationDaysPerYear { get; }
        void Vacation();
        void DayOff();   
        int Salary();
    }   
}
