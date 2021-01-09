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
            Console.WriteLine("");
            Console.WriteLine("Below are the scores of the students");
            for (int i = 0; i < studentscores.Length; i++)
            {
                studentscores[i] = rand_Num.Next(Min, Max);
                Console.WriteLine(studentscores[i]);
                int scores = studentscores[i];
                
            }
            Console.WriteLine("");
            Console.WriteLine("The total number of student in class is " + studentscores.Length ); 
            Console.WriteLine("");
            Console.WriteLine("The list of scores of student below 50 "); 
            foreach (var item in studentscores)
            {
                 if (item <= 50)
                 {
                    Console.WriteLine(item + "");
                 }
           }
            Console.WriteLine("");
            Console.WriteLine("The list of scores of student between 50 and 69 "); 
            foreach (var item in studentscores)
            {
                 if (item >= 50 && item <= 69)
                 {
                    Console.WriteLine(item);
                 }
           }
            Console.WriteLine("");
            Console.WriteLine("The list of scores of student from 70 and above "); 
            foreach (var item in studentscores)
            {
                 if (item >= 70)
                 {
                    Console.WriteLine(item);
                 }
           }


    }   }
}
