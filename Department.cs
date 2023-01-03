using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Lecture> Lectures { get; set; }
        public List<Student> Students { get; set; }

        public Department()
        {
        }
        public Department(string name)
        {
            Name = name;
            Lectures = new List<Lecture>();
            Students = new List<Student>();
        }
    }
}
