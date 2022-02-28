﻿using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create FileInfo object for DummyFile.txt
            FileInfo fi = new FileInfo(@"D:\DLithe_DotnetFSD_JanFeb2022\Venkateswara Reddy\Front End\C sharp\DLithe_BC_NFS_T_Task32\textfile.txt");

            //open DummyFile.txt for read operation
            FileStream fsToRead = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //open DummyFile.txt for write operation
            FileStream fsToWrite = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //get the StreamReader

            StreamReader sr = new StreamReader(fsToRead);
            //read all texts using StreamReader object
            string fileContent = sr.ReadToEnd();
            sr.Close();

            //get the StreamWriter
            StreamWriter sw = new StreamWriter(fsToWrite);
            //write some text using StreamWriter
            sw.WriteLine("Welcome to Files Concept in CSharp");
            sw.Close();

            //close all Stream objects
            fsToRead.Close();
            fsToWrite.Close();
        }
    }
}
