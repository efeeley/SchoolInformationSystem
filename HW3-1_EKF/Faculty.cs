﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3_1_EKF
{
    class Faculty : Person
    {
        public Faculty() { }//end constructer

        public Faculty(String aFirstName, String aLastName, char aGender, DateTime aDateOfBirth)
        {
            setFirstName(aFirstName);
            setLastName(aLastName);
            setGender(aGender);
            setDateOfBirth(aDateOfBirth);
            CreateID();

            Console.WriteLine(Display());
            Console.ReadLine();
        }//end public Faculty

        public override string Display()
        {
            return "You created a Faculty Member: " +
                "\n   Name: " + getFirstName() + " " + getLastName() +
                "\n   Gender: " + getGender() +
                "\n   Birth Date: " + getDateOfBirth() +
                "\n   Email Address: " + getIDNumber() + "@sullivan.edu";
        }//end override Display

        public override void CreateID()
        {
            string temp;
            //get the first letter of the first name
            temp = getFirstName().Substring(0, 1);
            //get the last name
            temp = temp + getLastName();
            //make all lower case
            temp = temp.ToLower();
            //store all of that as the idNumber
            this.setIDNumber(temp);
        }//end override CreateID
    }//end class Faculty:Person
}//end namespace HW3-1_EKF
