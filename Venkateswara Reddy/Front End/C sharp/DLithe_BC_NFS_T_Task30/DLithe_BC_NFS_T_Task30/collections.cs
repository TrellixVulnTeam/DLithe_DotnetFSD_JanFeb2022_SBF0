﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = new ArrayList();   //arraylist collection
            data.Add("Demo");             // add element
            data.Add(1);
            data.Add(5);
            data.Add(26);
            data.Add(56.4);
            data.Add(32);
            data.Remove(5);              // remove element
            foreach (object obj in data)   // iteration
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }

            Console.WriteLine("list for collections");
            var value = new List<string>();          // list collection
            value.Add("banana");                       // add element
            value.Add("mango");
            value.Add("orange");
            value.Add("grapes");
            value.Add("strawberry");
            value.Add("panasa");
            value.Remove("panasa");              // remove element
            value.Remove("grapes");
            value.Insert(3, "flower");         // insert element
            foreach (string st in value)
            {
                Console.WriteLine(st);
                Console.ReadLine();
            }

        }
    }
}