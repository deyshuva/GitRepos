using System;

namespace ArrayHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string word = Console.ReadLine();
            int n = word.Length;
            //array
            char[] myArray = new char [n];
            //myArray = word.ToCharArray();

            for(int i=0; i< n;i++)
            {
                myArray[i] = word[i];
                Console.WriteLine(myArray[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Index [{0}] = {1} ", i, myArray[i]);
            }



        }
    }
}
