﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Project
{
    class StringReverser {
        public void reverse(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count != 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count != 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
    }
    //class StringReverserusingQueue
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue<int> queue = new Queue<int>();
    //        queue.Enqueue(100);
    //        queue.Enqueue(200);
    //        queue.Enqueue(300);
    //        StringReverser sr = new StringReverser();
    //        sr.reverse(queue);
    //        foreach (var item in queue)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.ReadKey();
    //    }
    //}
}
