using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Mylist<T>
    {
        public T[] Arrr = new T[0];

        public void Add(T value)
        {
            Array.Resize(ref Arrr, Arrr.Length + 1);
            Arrr[Arrr.Length - 1] = value;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= Arrr.Length)
                throw new IndexOutOfRangeException();

            for (int i = index; i < Arrr.Length - 1; i++)
            {
                var temp = Arrr[i];
                Arrr[i] = Arrr[i + 1];
                Arrr[i + 1] = temp;
            }
            Array.Resize(ref Arrr, Arrr.Length - 1);
        }
    }
}
