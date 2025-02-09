/*
* FILE : Program.cs
* PROJECT :PROG1385 – OBJECT ORIENTED PROGAMMING - Assignment #4
* PROGRAMMER : Ayushpreet Singh
* FIRST VERSION : 2025-02-09
* DESCRIPTION :
* The function in this file defines a class called UI which takes a string and print it
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    /// <summary>
    /// The UI class of the program. It has only one method Display which prints the output foe the program
    /// </summary>
    internal class UI
    {
        /// <summary>
        /// it takes a string and print it using Console.Writeline
        /// </summary>
        /// <param name="output"></param>
        public void Display(string output)
        {

            Console.WriteLine(output);      //printing the output
        
        }

    }
}
