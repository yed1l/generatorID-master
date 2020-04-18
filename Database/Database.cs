using System.Collections.Generic;
using generatorID.Models;

namespace generatorID
{
    public class Database
    {
        
        private Database() {}
        public static Database shared = new Database();

        public List<Student> students
        {
            get
            {
                List<Student> students = new List<Student>();
                students.Add(new Student("Messi", "08-12-2000", "CSSE-1704K"));
                students.Add(new Student("Ibra", "19-08-1999", "CSSE-1704K"));
                students.Add(new Student("Mahrez", "08-12-1974", "CSSE-1701K"));
                students.Add(new Student("Aguero", "19-08-1998", "CSSE-1706K"));
                students.Add(new Student("Bonucci", "28-05-1999", "CSSE-1703K"));
                students.Add(new Student("Suso", "19-08-1997", "CSSE-1703K"));
                students.Add(new Student("Casemiro", "08-12-2000", "CSSE-1703K"));
                students.Add(new Student("Salah", "19-08-2002", "CSSE-1905K"));
                students.Add(new Student("Varane", "08-12-2003", "CSSE-1905K"));
                students.Add(new Student("Son", "08-12-1990", "CSSE-1707K"));
                students.Add(new Student("Kane", "08-10-1996", "CSSE-1707K"));
                students.Add(new Student("Hazard", "28-05-1994", "CSSE-1707K"));
                return students;
            }
        }
    }
}