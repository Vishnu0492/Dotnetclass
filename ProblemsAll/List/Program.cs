namespace List
{
    internal class Program
    {
        class Employee
        {

            public int EmpID { get; set; }
            public int EmpName { get; set; }
            public int EmpSalary { get; set; }
            public void getdata()
            { Console.WriteLine("Please enter employee id");
                EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter employee id");
                EmpName = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter employee id");
                EmpSalary = Convert.ToInt32(Console.ReadLine());

            }

        }
        internal class GenericCollections
            {
            
            public void main()
            {
                List<Employee> emplist = new List<Employee>();
            for (int i=0;i<10;i++)
                {
                    Employee obj = new Employee();
                    obj.getdata();
                    emplist.Add(obj);
                }
            foreach(var item in emplist)
                {
                    Console.WriteLine("Employee ID"+item.EmpID);
                    Console.WriteLine("Employee Name" + item.EmpName);
                    Console.WriteLine("Employee Salary" + item.EmpSalary);
                }
            }
            }
        
    }
}