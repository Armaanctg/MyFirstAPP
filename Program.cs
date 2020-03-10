using System;

namespace Jagged_Array
{
    class Program
    {
        static void  Main(string[] args)
        {
            String[][] JaggedArray =new string [3][]
           {
                new string[] {"BBA","EMBA"},
                new string[] { "Bsc", "MSc", "SSc" },
                new string[] { "Ssc" }
            };

            Console.WriteLine(JaggedArray[0] [0]);
            Console.WriteLine(JaggedArray[0] [1]);

            Console.WriteLine(JaggedArray[1] [0]);
            Console.WriteLine(JaggedArray[1] [1]);

            Console.WriteLine(JaggedArray[1][2]);

            Console.WriteLine(JaggedArray[2][0]);
        }
           

    }
}
