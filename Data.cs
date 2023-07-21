using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise01
{
    public class Data
    {
        string name;
        int id;
        public Data(int id,string name) {
            this.id = id;
            this.name = name;
        }
        public int getId() { return id; }
        public string getName() { return name; }
    }
}
