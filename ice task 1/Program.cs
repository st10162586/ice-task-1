// See https://aka.ms/new-console-template for more information


using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.WebSockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        entrance();
    }



    public static void entrance()
    {
        int questions;
        int papers;
        int lectures;
        int marks;
        int a = 0;
        int b;
        int c;
        int tic;
        int d;


        do
        {
            Console.WriteLine("how many papers are there to mark ");
            papers = Convert.ToInt32(Console.ReadLine());
        } while (papers == 0);

        do
        {
            Console.WriteLine("how many questions in the paper or papers ( must be from 1 to 10)");
            questions = Convert.ToInt32(Console.ReadLine());
        } while (questions == 0 || questions > 10);

        for (int i = 1; i <= questions; i++)
        {
            Console.WriteLine("how many marks for Question" + " " + i);
            marks = Convert.ToInt32(Console.ReadLine());
            a += marks;
        }

        do
        {
            Console.WriteLine("how many lectures are there marking ");
            lectures = Convert.ToInt32(Console.ReadLine());
        } while (lectures == 0);


        b = papers / lectures;


        Console.WriteLine("number of papers to be marked" + " " + papers);
        Console.WriteLine("");
        Console.WriteLine("number of papers each lecturer will mark is" + " " + b);
        tic = 2;
        c = a * tic;
        d = c * papers;

        TimeSpan time = TimeSpan.FromSeconds(d);
        Console.WriteLine("the total time lectures will mark for is " + " " + time);







    }



}

