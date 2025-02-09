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
    public class MemberOfSocialClub
    {
        public int MemberId;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public DateTime DateOfBirth;

        public void SetAllData(int id, string firstname, string lastname, string emailaddress, DateTime dob)
        {
            MemberId = id;
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = emailaddress;
            DateOfBirth = dob;
        }

        public string GetName()
        {
            return $"{LastName}, {FirstName}";
        }


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
