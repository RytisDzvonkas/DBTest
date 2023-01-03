using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Department> Departments { get; set; }
        public Lecture()
        {
        }
        public Lecture(string name, string code)
        {
            Name= name;
            Code= code;
            Departments = new List<Department>();
        }
    }
}
