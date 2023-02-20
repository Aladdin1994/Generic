using System;
using System.Collections;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StringList stringList= new StringList();
         //  Mylist<string> stringList = new Mylist<string>();  
            stringList.Add("sdadsad");
            stringList.Add("dsader");

            stringList.Remove(0);

           foreach(string str in stringList.Arrr)
            {
                Console.WriteLine(str);
            }

            int[] nums = { 12, 34, 88, 15, 55, 6 };

            for(int i=2;i<nums.Length-1;i++) 
            {
                var temp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;
            }
            foreach(var item in nums) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================================");
           //Mylist<double> dblist = new Mylist<double>();
           // Mylist<char>chrlist= new Mylist<char>();






           


        }


    }
}
