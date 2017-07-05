using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 7/12/2012
 * Assingment: HW3-1_EKF (PersonTest)
 * Resources: N/A
 * ***********************************/

namespace HW3_1_EKF
{
    abstract class Person
    {
        //Attributes
        private String firstName, lastName, idNumber;
        private char gender;
        private DateTime dateOfBirth;

        //Methods
        public Person() { }

        public Person(String aFirstName, String aLastName, char aGender, DateTime aDateOfBirth)
        {
            setFirstName(aFirstName);
            setLastName(aLastName);
            setGender(aGender);
            setDateOfBirth(aDateOfBirth);
            CreateID();

            Console.WriteLine(Display());
            Console.ReadLine();
        }//end public Person

        //sets
        public void setFirstName(string aFirstName)
        {
            this.firstName = aFirstName;
        }//end method setFirstName
        public void setLastName(string aLastName)
        {
            this.lastName = aLastName;
        }//end method setLastName
        public void setGender(char aGender)
        {
            this.gender = aGender;
        }//end method setGender
        public void setDateOfBirth(DateTime aDateOfBirth)
        {
            this.dateOfBirth = aDateOfBirth;
        }//end method setDateOfBirth
        public void setIDNumber(string aIDNumber)
        {
            this.idNumber = aIDNumber;
        }//end method setIDNumber

        //gets
        public string getFirstName()
        {
            return this.firstName;
        }//end method getFirstName
        public string getLastName()
        {
            return this.lastName;
        }//end method getLastName
        public char getGender()
        {
            return this.gender;
        }//end method getGender
        public DateTime getDateOfBirth()
        {
            return this.dateOfBirth;
        }//end method getDateOfBirth
        public string getIDNumber()
        {
            return this.idNumber;
        }//end method getIDNumber
        
        //More Methods
        public abstract string Display();//end abstract Display

        public abstract void CreateID();//end abstract CreateID
    }
}
