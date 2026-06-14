using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr15_Moskvina_
{
    public class Student
    {
        public string LastName {  get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNum { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName}, Дата рождения: {BirthDate.ToShortDateString()}, Тел.: {PhoneNum}";
        }

    }
}
