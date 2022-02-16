using System;

namespace Inheritance.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int workedHours, double valuePerHour, double additionalCharge) 
            : base(name, workedHours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double WorkerPayment()
        {
            return base.WorkerPayment() + (AdditionalCharge * 1.1);
        }
    }
}
