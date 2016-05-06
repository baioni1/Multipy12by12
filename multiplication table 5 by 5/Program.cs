using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table_5_by_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = "";
            for (int rows = 1; rows<=12 ; rows ++)  
            {
                
                for (int columns = 1; columns <=12; columns++)
                {
                    line = line + string.Format("{0,4}", rows * columns);
                }
                
                Console.WriteLine(line.Trim());
                line = "";
            }
            Console.WriteLine();
        }
        
    }
}
