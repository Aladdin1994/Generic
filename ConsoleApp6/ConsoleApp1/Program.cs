using System;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlist= new ArrayList(); 
            ArrayList arrayList= new ArrayList();
            arrayList.Add(34);
            arrlist.Add(1);
            arrlist.Add(2);
            arrlist.Add("Sdrf");
            arrlist.Add("d");

         //   arrlist.Remove(1);
           // arrlist.Clear();
            arrlist.AddRange(arrayList);
           // arrlist.RemoveRange(1, 3);
           // arrlist.RemoveAt(0);
            arrlist.LastIndexOf(2);
           // arrlist.Sort();

           // arrlist.Reverse();
            arrlist.Insert(0,5);
           bool R= arrlist.Contains(5);
            Console.WriteLine(R);

            

            foreach(var item in arrlist)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("==========================queue==============");
            Queue queue= new Queue();

            queue.Enqueue(5);
            queue.Enqueue(34);
            queue.Enqueue(32);
            queue.Enqueue("REWQR");
            queue.Enqueue('w');

             var value= queue.Dequeue();   
             value = queue.Peek();
             value = queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);    
            }

            Console.WriteLine("===================stack==========================");

            Stack stack= new Stack();   

            stack.Push(5);
            stack.Push(232);
            stack.Push("dewad");

            // value=stack.Pop();
            value = stack.Peek();



            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

           // arrayList.AddRange(queue);



            SortedList sortedList = new SortedList();
            sortedList.Add("Asif",9);
           


             


           Console.WriteLine(sortedList["Asif"]);

        }
    }
}
