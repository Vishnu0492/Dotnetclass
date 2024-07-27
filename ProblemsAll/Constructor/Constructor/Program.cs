namespace Constructor
{

    class Student
    {
        public int ID;
        public String StudentName;
        public String StudentEmail;
        public Student(int id, String Name)
        {
            ID = id;
            StudentName = Name;

        }

        public void printStudentData()
        {
            Console.Write(StudentName);
            Console.Write(ID);

        }

    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(123, "Vishnupriya");
            student.printStudentData();
        }
    }
}