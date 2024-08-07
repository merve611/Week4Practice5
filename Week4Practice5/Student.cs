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

        public override void InfoPerson()                   //Base sınıftaki ınfo metodu burada override edilerek tekrar kullanıldı
        {
            Console.WriteLine("Öğrencinin adı : " + FirstName + "Soyadı : " + LastName + " Numarası : " + StudentNumber);
        }
    }

   
}
