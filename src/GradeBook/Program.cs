﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[3];
            //numbers[0] = 34.4;

            if(args.Length > 0){
                Console.WriteLine($"Hello, {args[0]} !");
            }else{
            //String interpolation
                Console.WriteLine("Hello!");
            }//if else-if
        }
    }
}
