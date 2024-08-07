using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public void TeacherInfo()           //Öğretmen bilgilerini veren metot
        {
            
            InfoPerson();                   //Base sınıfta yazdığımız bilgi metodunu burda kullandık
            Console.WriteLine("Öğretmenin maaşı : " + Salary);

        }
    }
}
