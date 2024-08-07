using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice5
{
    public class BasePerson
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void InfoPerson()            //İsim ve soyisim yazdıran metot
        {
            Console.WriteLine("İsim : " + FirstName + " Soyadı : " + LastName);
        }
    }

    
}