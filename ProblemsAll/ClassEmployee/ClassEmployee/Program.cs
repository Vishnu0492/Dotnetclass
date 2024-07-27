namespace ClassEmployee
{
    class Employee
    {
        public int EmpId;
        public String EmpName;
        public String Gender;
        public String Designation;
        public String EmpSal;

        public void PrintData( Employee employee)
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine(employee.EmpName);
            Console.WriteLine(employee.EmpId);
            Console.WriteLine(employee.Gender);
            Console.WriteLine(employee.Designation);
            Console.WriteLine(employee.EmpSal);
               



        }

    }
    internal class Demo
    {
       
        public static void Main()
        {
            Employee employee = new Employee();
            Employee EmpName = "Vishnupriya";
            Employee EmpId = 195236;
            Employee Gender = "F";
            Employee Designation = "Developer";
        }
    }
}