using System;

namespace Inheritance.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int WorkedHours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int workedHours, double valuePerHour)
        {
            Name = name;
            WorkedHours = workedHours;
            ValuePerHour = valuePerHour;
        }

        public virtual double WorkerPayment()
        {
            return WorkedHours * ValuePerHour;
        }
    }
}
