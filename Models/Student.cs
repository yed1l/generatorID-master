using System.Collections.Generic;

namespace generatorID.Models
{
    public class Student
    {
        public string FullName { get; set; }
        public string DOB { get; set; }
        public string Group { get; set; }

        public Student(string FullName, string DOB, string Group)
        {
            this.FullName = FullName;
            this.DOB = DOB;
            this.Group = Group;
        }
    }
}