using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice5
{
    public class Teacher : BasePerson
    {
        public Teacher(string firstName, string lastName, int salary)                   // //Parametreli ctor (Program.cs de tanımlamada kullanmak için yazdım)
        {
            {
                FirstName = firstName;
                LastName = lastName;
                Salary = salary;
            }
        }
        public double Salary { get; set; }
       
        public override void InfoPerson()                   //Base sınıftaki ınfo metodu burada override edilerek tekrar kullanıldı
        {
            Console.WriteLine("Öğretmenin adı : " + FirstName + "Soyadı : " + LastName + " Maaşı : " + Salary);
        }



    }

}
