
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo3
{
    interface ITestinterface
    {
        void ArrayList();
    }
    interface ITestinterface1
    {
        void Stack();
        void Queue();
        void Sorted();
    }
    class Child : ITestinterface, ITestinterface1
    {

        
        public void ArrayList()
        {
            ArrayList a = new ArrayList() { 10, "hi", 3, 20, true, null };

           
            a.Add(1);
            a.Add("hi");
            a.Insert(2, 100);
           a.Remove(3);
            

            Console.WriteLine("ARRAYLIST");

            foreach (var value in a)
                Console.WriteLine(value);

            a.RemoveRange(1, 2);
            a.Reverse();
      
            foreach (var value in a)
                Console.WriteLine(value);


            a.RemoveAt(2);
            Console.WriteLine("element present : " + a.Contains(100));

            Console.WriteLine("element present : " + a.Contains(null));


        }
        public void Stack()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(null);
            s.Push("hi");
            s.Push(true);
            s.Pop();
            Console.WriteLine();
            Console.WriteLine("STACK");
            foreach (var value in s)
                Console.WriteLine(value);

            Console.WriteLine("element present : " + s.Contains(1));

            Console.WriteLine("element present : " + s.Contains(null));



        }
        public void Queue()
        {
            Queue q = new Queue();
            q.Enqueue("C#");
            q.Enqueue(2.14f);
            q.Enqueue(false);
            q.Enqueue("Js");
            q.Dequeue();
            Console.WriteLine();
            Console.WriteLine("QUEUE");
            foreach (var value in q)
                Console.WriteLine(value);
            Console.WriteLine("elements : " + q.Contains("Js"));
            
        }
        public void Sorted()
        {
            SortedList st = new SortedList() { { 1, "one" }, { 3, "two" }, { 5, "five" }, { 6, "three" } };
            
            Console.WriteLine();
            Console.WriteLine("SORTED");
            string i = (string)st[1];
           string j = (string)st[5];
            string z = (string)st[3];

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(z);
            for (int b = 0; b < st.Count; b++)
            {
                Console.WriteLine("key: {0}, value: {1}",
                    st.GetKey(b), st.GetByIndex(b));
            }
            st.Remove(1);//removes element whose key is 'one'
            st.RemoveAt(0);//removes element at zero index i.e first element: four
            Console.WriteLine();
            foreach (DictionaryEntry vst in st)
                Console.WriteLine("key: {0}, value: {1}", vst.Key, vst.Value);


        }

    }
}


