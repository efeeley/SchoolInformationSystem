using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3_1_EKF
{
    class Student: Person
    {
        public Student() { }//end constructer

        public Student(String aFirstName, String aLastName, char aGender, DateTime aDateOfBirth)
        {
            setFirstName(aFirstName);
            setLastName(aLastName);
            setGender(aGender);
            setDateOfBirth(aDateOfBirth);
            CreateID();

            Console.WriteLine(Display());
            Console.ReadLine();
        }//end public Student

        public override string Display()
        {
            return "You created a Student: " +
                "\n   Name: " + getFirstName() + " " + getLastName() +
                "\n   Gender: " + getGender() +
                "\n   Birth Date: " + getDateOfBirth() +
                "\n   Email Address: " + getIDNumber() + "@my.sullivan.edu";
        }//end override Display

        public override void CreateID()
        {
            string temp;
            //get the first letter of the first name
            temp = getFirstName().Substring(0, 1);
            //get the first 5 letters of the last name
            temp = temp + getLastName().Substring(0, 5);
            //add 4 random digits
            Random rnd = new Random();
            temp = temp + rnd.Next(1000, 10000);
            //make it all caps
            temp = temp.ToUpper();
            //store all of that as the idNumber
            this.setIDNumber(temp);
        }//end override CreateID
    }//end class Student:Person
}//end namespace HW3-1_EKF
