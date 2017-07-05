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
    class PersonTest
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bruce", "Almighty", 'M', new DateTime(2012, 12, 22));
            Staff staff1 = new Staff("Amy", "Farafaller", 'F', new DateTime(1984, 1, 25));
            Faculty faculty1 = new Faculty("Sheldon", "Cooper", 'M', new DateTime(1986, 5, 7));
        }
    }
}
