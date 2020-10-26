using System;

namespace Open_Lab_03._03
{
    public class Comparator
    {
        public bool CompareCharactersCount(string str1, string str2)
        {
           if(str1.Length > str2.Length)
           {
            Console.WriteLine("String str1 is longer");
           }
           else
           {
            Console.WriteLine("String str2 is longer");
           }
        }
    }
}
