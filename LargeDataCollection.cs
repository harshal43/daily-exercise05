using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise01
{

    public class LargeDataCollection : IDisposable
    {
        bool disposedValue;
        Data empData = null;
        double salary;
        string designation;
        static int noEmp = 0;

        public LargeDataCollection(int id, string name, double salary, string designation)
        {
            if (empData == null)
            {
                empData = new Data(id, name);
                noEmp++;
            }
            Console.WriteLine("New employee's data is added!");
            Console.WriteLine("No. of employees are:\t" + noEmp);
            this.salary = salary;
            this.designation = designation;
        }

        public void GetData()
        {
            Console.WriteLine("Employee ID is:\t"+empData.getId());
            Console.WriteLine("Employee Name is:\t"+empData.getName());
            Console.WriteLine("Employee Designation is:\t"+designation);
            Console.WriteLine("Employee Salary is:\tRs. "+salary);
        }
        public virtual void Dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if(disposing)
                {
                    noEmp = 0;
                }
                Console.WriteLine($"The {empData.getId()}: {empData.getName()} has been removed from database!");
                empData = null;
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
