/*
* FILE : Program.cs
* PROJECT :PROG1385 – OBJECT ORIENTED PROGAMMING - Assignment #4
* PROGRAMMER : Ayushpreet Singh
* FIRST VERSION : 2025-02-09
* DESCRIPTION :
* The function in this file defines a class called Run and it contains a method that is the actual program logic
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    /// <summary>
    /// Class called Run with only one method Logic to check logic of the program
    /// </summary>
    internal class Run
    {
        /// <summary>
        /// It contains the logic of the program. First it sets all the data members of 5 members of class MemberOfSocialMedia and 
        /// also creates a UI class to display output by calling the GetName and CalculateAge of MemberOfSocialMedia class. 
        /// </summary>
        public void Logic()
        {
            UI ui = new UI();   //Istantination of a UI class
            
            MemberOfSocialClub[] memberOfSocialClubs = new MemberOfSocialClub[5];


            for (int i = 0; i < memberOfSocialClubs.Length; i++)        //loop to create and also set 5 member's data
            {
                memberOfSocialClubs[i] = new MemberOfSocialClub();
                memberOfSocialClubs[i].SetAllData(((i * i * i * 8) - (i * i)), $"Hell{i}o", $"W{i}orld", $"{i}HelloWorld.{i}@gmail.com", new DateTime(2001 + i, 02, 14));
            }

            foreach (var memberOfSocialClub in memberOfSocialClubs) //loop to display output from each member from the array of 5
            {
                
                ui.Display($"Member's Name: {memberOfSocialClub.GetName()}");

                ui.Display($"Member's Age: {memberOfSocialClub.CalculateAge()}");

            }

        }

    }
}
