using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeometricCalculator
{
    class Log
    {
        public void log( object result )
        {
            //string line = "Type: " + type + " Formula: " + formula + " Result: " + result;
            string line = "hej";
            using (StreamWriter w = File.AppendText("C:/Users/"+ Helpers.getActiveUser() +"/Documents/test.txt"))
            {
                w.WriteLine(line);
            }
        }
    }
}
