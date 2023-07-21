using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargeDataCollection emp1 = new LargeDataCollection(01, "Harshal",87000,"Software Engineer");
            emp1.GetData();

            LargeDataCollection emp2 = new LargeDataCollection(02, "Rahul", 65000, "HR");
            emp2.GetData();
            emp2.Dispose();

            LargeDataCollection emp3 = new LargeDataCollection(03, "Sameer", 77000, "Consultant");
            emp3.GetData();
            Console.ReadKey();
        }
    }
}
