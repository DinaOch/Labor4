using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба4
{
    public abstract class Person
    {
        public string? FIO { get; set; }
    }

    public class Employee : Person
    {
        public int CertificateNumber { get; set; }
    }

    public class Student : Person
    {
        public int RecordBookNumber { get; set; }
    }

    public class StaffList
    {
        public List<Person> Persons { get; set; }

        public StaffList()
        {
            Persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            Persons.Add(person);
        }

        public int GetEmployeeCount()
        {
            return Persons.Count(p => p is Employee);
        }

        public int GetStudentCount()
        {
            return Persons.Count(p => p is Student);
        }
    }
}
