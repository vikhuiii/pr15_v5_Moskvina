using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr15_Moskvina_
{
    internal class StudentGroup
    {
        private List<Student> students=new List<Student>();
        public void AddStudents(params Student[] newStudents)
        {
            foreach (var student in newStudents)
            {
                students.Add(student);
            }
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public bool RemoveStudent(int id)
        {
            if (id >= 0 && id < students.Count)
            {
                students.RemoveAt(id);
                return true;
            }
            return false;
        }
        public List<Student> FindByLastName(string lastname)
        {
            return students.Where(s => s.LastName.Equals(lastname, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Student> SortByLastName(List<Student> list)
        {
            return list.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
        }
        public List<Student> SortByBirthDate(List<Student> list)
        {
            return list.OrderBy(s => s.BirthDate).ToList();
        }
        public List<Student> SortByPhoneNum(List<Student> list)
        {
            return list.OrderBy(s => s.PhoneNum).ToList();
        }
        public List<Student> GetAllStuds()
        {
            return students.ToList();
        }
        public int Count => students.Count;
    }
}
