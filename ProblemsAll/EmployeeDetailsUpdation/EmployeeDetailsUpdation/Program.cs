namespace EmployeeDetailsUpdation
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    static Employee[] employee = new Employee[100];
    static int emoloyeecount = 0;
    static void main()
    {
        bool datasrunning = true;
        while (datsrunning)
        {
            Console.Clear();
            ShowMenu();
            int choice = GetChoice();
            switch (choice)
            {

                case 1:
                    AddEmployee();
                    break;
                case 2:
                    UpdateEmployee();
                    break;
                case 3:
                    DeleteEmployee();
                    break;
                case 4:
                    ListEmployee();
                    break;
                case 5: datasrunning = false; break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option");
                    break;
            }
            if (datasrunning)
            {

                Console.WriteLine("Press any Key to Continues..");
                Console.ReadKey();
            }
        }


        static void ShowMenu()
        {

            Console.WriteLine("Employee Management System");
            Console.WriteLine("1.Add Employee");
            Console.WriteLine("2.Update Employee");
            Console.WriteLine("3.Delete Employee");
            Console.WriteLine("4.List Employee");
            Console.WriteLine("5.Exit");
        }
        static int GetChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {

                Console.WriteLine("Please Enter a valid number between 1 and 5");
            }
            return choice;
        }

        static void AddEmployee()
        {
            if (employeeCount >= Employee.Length)
            {
                Console.WriteLine("Employee list is full");
                return;
            }
            Console.WriteLine("Enter Employee ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Employee[employeeCount++] = new Employee(id, name);
            Console.WriteLine("Employee added successfully");
        }
        static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee ID to Update");
            int id = int.Parse(Console.ReadLine());
            Employee emp = FindEmployeeById(id);
            if (emp==null)
            {
                Console.WriteLine(" Employee Name not found");
                return;
            }

            Console.WriteLine("Enter new Name");
            emp.Name = Console.ReadLine();
            
            Console.WriteLine("Employee updated successfully");

        }
        static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee ID to Delete");
            int id = int.Parse(Console.ReadLine());
            int index = FindEmployeeById(id);
            if (index == -1)
            {
                Console.WriteLine(" Employee not found");
                return;
            }
            for(int i=index;i<employeeCount-1;i++)
            {

                Employee[i] = Employee[i + 1];
            }
            Employee[--employeeCount] = null;

            Console.WriteLine("Enter new Name");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Employee deleted successfully");

        }
        static void ListEmployee()
        { if(employeeCount==0)
            {
                Console.WriteLine("No employee to display");
                return;

            }
            Console.WriteLine("Employee List:");
            for(int i=0;i<employeeCount;i++)
            {
                Console.WriteLine($"ID:{employee[i].id} Name:{employee[i].Name");

            }

        }
            static int FindEmployeeIndexById()
            {
                foreach(var emp in employees)
                {
                    if(emp!=null&& emp.Id==id)
                    {
                        return emp;
                    }
                    return null;
                }
            }
            static int FindEmployeeIndexById(int id)
            {
                for (int i=0;i<employeeCount;i++)
                {
                    if (Employee[i].id==id)
                    {
                        return i;
                    }
                    return -1;
                }

            }
    

   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
  
    
    }
}