using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_Example.Models
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
    }
}
