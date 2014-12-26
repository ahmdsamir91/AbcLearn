using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithJson
{
    class Program
    {
        //[STAThread]
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Json To GitHub");
            var jsonOutputTest = new JsonOutputTest();
           // jsonOutputTest.IterateOverJsonObject(jsonOutputTest.JsonObjectOutputTest());
            jsonOutputTest.PlayWithJsonData();
            
        }
    }
}
