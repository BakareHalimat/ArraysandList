using System;
using System.Linq;

namespace ArraysandList
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 1;
            int Max = 100;
            Random randNum = new Random();
            int[] studentscores = new int[randNum.Next(35,100)];
            Random rand_Num = new Random();
            for (int i = 0; i < studentscores.Length; i++)
            {
                studentscores[i] = rand_Num.Next(Min, Max);
               // Console.WriteLine(studentscores[i]);
                int scores = studentscores[i];
                //int[] newscores = new int[scores];
                
                //Console.WriteLine("The total number of student in class is " + newscores.);
            }
                
    }   }
}
