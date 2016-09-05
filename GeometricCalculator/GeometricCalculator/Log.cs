using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeometricCalculator
{
    class Log : Print
    {
        public void log( string type, string formula, string result )
        {
            string line = "Type: " + type + " Formula: " + formula + " Result: " + result;
          
            using (StreamWriter w = File.AppendText("C:/Users/"+ Helpers.getActiveUser() +"/Documents/test.txt"))
            {
                w.WriteLine(line);
            }
        }

       

    }
}
