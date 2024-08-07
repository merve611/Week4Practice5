using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice5
{
    public class Student : BasePerson
    {
        public Student(string firstName, string lastName, int studentNumber)        //Parametreli ctor (Program.cs de tanımlamada kullanmak için yazdım)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentNumber = studentNumber;

        }

        public int StudentNumber { get; set; }                                     //Student a ait property

        public void StudentInfo()           //Öğrenci bilgilerini veren metot
        {
            
            InfoPerson();           //Base sınıfta yazdığımız bilgi metodunu burda kullandık
            Console.WriteLine("Öğrencinin numarası : " + StudentNumber);
        }
    }

   
}
