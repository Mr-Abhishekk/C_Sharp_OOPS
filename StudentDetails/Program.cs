namespace StudentDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDetails student = new StudentDetails("Anika", 31, "VII", "AECS", "Bengaluru");
            student.Details();
            StudentDetails student1 = new StudentDetails("Tanmay", 40, "V", "St.Joseph", "Hyderabad");
            student1.Details();
            StudentDetails student2 = new StudentDetails("Jhanavai",35, "IX", "DPS", "Chennai");
            student2.Details();
            Console.ReadLine();
        }


    class StudentDetails
        {
            public string StudentName;
            public int RollNo;
            public string Std;
            public string SchoolName;
            public string City;
            public StudentDetails(string studentname, int rollno, string std, string schoolname, string city )
            {
                StudentName = studentname;
                RollNo = rollno;
                Std = std;
                SchoolName =schoolname;
                City = city;
            }

            public void Details()
            {
              
                Console.WriteLine($"Student name is {StudentName}");
                Console.WriteLine($"Student Rollno is {RollNo}");
                Console.WriteLine($"Student std is {Std}");
                Console.WriteLine($"Student SchoolName is {SchoolName}");
                Console.WriteLine($"Student City is {City}");
                Console.WriteLine("-----------------------------");
            }

        }
    }

}
