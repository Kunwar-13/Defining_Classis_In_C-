/*
* FILE : Program.cs
* PROJECT :PROG1385 – OBJECT ORIENTED PROGAMMING - Assignment #4
* PROGRAMMER : Ayushpreet Singh
* FIRST VERSION : 2025-02-09
* DESCRIPTION :
* The function in this file defines a class called MemberOfSocialClub and it's datamembers and methods
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    /// <summary>
    /// A class that represents a member in a social club. 
    /// It has 5 public data members. A method to set values of all the data members.
    /// A method GetName to get the first and last name of the member.
    /// A method to get the member's age.
    /// </summary>
    public class MemberOfSocialClub
    {
        //Data Mambers
        public int MemberId;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public DateTime DateOfBirth;

        /// <summary>
        /// Sets values of all data members based on their corresponding counterpart in the parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="emailaddress"></param>
        /// <param name="dob"></param>
        public void SetAllData(int id, string firstname, string lastname, string emailaddress, DateTime dob)
        {
            MemberId = id;
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = emailaddress;
            DateOfBirth = dob;
        }

        /// <summary>
        /// It returns the name of member in {Lastname, Firstname} style
        /// </summary>
        /// <returns>String= L.n, F.n</returns>
        public string GetName()
        {
            return $"{LastName}, {FirstName}";
        }


        /// <summary>
        /// It calculates the age only based on years in years
        /// </summary>
        /// <returns>int = age(in years)</returns>
        public int CalculateAge()
        {
            if (DateOfBirth < DateTime.Now)
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
            else
            {
                return -1;
            }
        } 

    }
}
