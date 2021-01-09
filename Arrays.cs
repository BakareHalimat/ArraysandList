using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Array(string[] args)
        {
            int[] studentscores = new int[40];
            studentscores[0] = 25;
            studentscores[1] = 15;
            studentscores[2] = 100;
            studentscores[3] = 90;
            studentscores[4] = 80;           
            studentscores[5] = 70;
            studentscores[6] = 60;
            studentscores[7] = 50;
            studentscores[8] = 40;
            studentscores[9] = 30;
            studentscores[10] = 20;
            studentscores[11] = 10;
            studentscores[12] = 30;
            studentscores[13] = 40;
            studentscores[14] = 35;
            studentscores[15] = 45;
            studentscores[16] = 55;           
            studentscores[17] = 65;
            studentscores[18] = 75;
            studentscores[19] = 85;
            studentscores[20] = 95;
            studentscores[21] = 100;
            studentscores[22] = 15;
            studentscores[23] = 35;
            studentscores[24] = 15;
            studentscores[25] = 100;
            studentscores[26] = 92;
            studentscores[27] = 88;           
            studentscores[28] = 77;
            studentscores[29] = 66;
            studentscores[30] = 55;
            studentscores[31] = 44;
            studentscores[32] = 33;
            studentscores[33] = 22;
            studentscores[34] = 12;
            studentscores[35] = 32;
            studentscores[36] = 43;
            studentscores[37] = 32;
            studentscores[38] = 41;
            studentscores[39] = 52;

            Console.WriteLine("The total number of student in class is "+ studentscores.Length);
            Console.WriteLine("");
            Console.WriteLine("The list of students that passed");
            foreach (var house in studentscores)
            {
                
                if (house >= 70)
                {
                    Console.WriteLine(house);   
                }
            }
            Console.WriteLine("");
            Console.WriteLine("The list of students that failed");
            foreach (var item in studentscores)
            {
                if (item <= 50)
                {
                    
                    Console.WriteLine(item);
                }
                
            }
            Console.WriteLine("");
            
            Console.WriteLine("The list of students that got an avarege score");
            foreach (var item in studentscores)
            {
                if(item >= 50 && item <= 69)
                {
                    Console.WriteLine(item);
                }
                
            int[] result = item.ToString().Select(o=>Convert.ToInt32(o)).ToArray();
            Console.WriteLine(result.Length);
            }       
    }   }
}