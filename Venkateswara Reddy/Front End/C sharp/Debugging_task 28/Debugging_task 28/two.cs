﻿namespace PropertyDemo
{
    public class Example
    {
        private int _empid, _eage;
        private string _ename, _eaddress;
        public int empid
        {
            set
            {
                _empid = value; //added _
            }
            get
            {
                return _empid;
            }
        }
        public int eage
        {
            set
            {
                _eage = value; //added semicolon
            }
            get
            {
                return _eage; // added return
            }
        }
        public string ename
        {
            set
            {
                _ename = value;
            }
            get
            {
                return _ename;
            }
        }
        public string eaddress
        {
            set
            {
                _eaddress = value;
            }
            get
            {
                return _eaddress;
            }
        }
    }
    class Program
    {
        static void Main(string[] args) //added args
        {
            Example obj1 = new Example(); // changed obj name to obj1
            obj1.empid = 101;
            obj1.ename = "pranaya";
            obj1.eage = 27; //deleted a 
            obj1.eaddress = "bbsr";
            Console.WriteLine("Employee details are:");
            Console.WriteLine("employee id:" + obj1.empid);
            Console.WriteLine("employee name:" + obj1.ename);// added + symbol
            Console.WriteLine("employee age:" + obj1.eage);
            Console.WriteLine("employee address:" + obj1.eaddress);///changed obj to obj1 
            Console.ReadKey();
        }
    }
}

