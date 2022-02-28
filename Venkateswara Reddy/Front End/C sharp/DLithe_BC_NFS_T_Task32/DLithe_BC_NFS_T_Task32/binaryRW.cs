﻿using System;
using System.IO;
namespace ConsoleApp4
{
    public class Demo
    {
        string fileLocation = @".\newBinaryFile.dat";
        public void WritingFile()
        {
            try
            {
                //checking if file exists
                if (File.Exists(fileLocation))
                {
                    File.Delete(fileLocation);
                }
                FileStream fileStream = new FileStream(fileLocation, FileMode.Create,
                FileAccess.Write, FileShare.ReadWrite);
                //creating binary file using BinaryWriter
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    //writing data using different Write() methods
                    //of BinaryWriter
                    binaryWriter.Write(6456);
                    binaryWriter.Write("This is a string value.");
                    binaryWriter.Write('K');
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void ReadingFile()
        {
            try
            {
                FileStream fileStream = new FileStream(fileLocation, FileMode.Open,
                FileAccess.Read, FileShare.ReadWrite);
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    Console.WriteLine("IntegerValue = " + binaryReader.ReadInt32());
                    Console.WriteLine("StringValue = " + binaryReader.ReadString());
                    Console.WriteLine("CharValue = " + binaryReader.ReadChar());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
    public class BinaryWriterDemo
    {
        static void Main(string[] args)
        {
            Demo demoObj = new Demo();
            demoObj.WritingFile();
            demoObj.ReadingFile();
            Console.ReadLine();
        }
    }
}