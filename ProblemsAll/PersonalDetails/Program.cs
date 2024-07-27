namespace PersonalDetails
{

    class Person
    {

        public String Name;
        public Person(Person person)
        {
            Name = person.Name;
        }
        public Person( String name)
        {
            this.Name = name;
        }
        public void PrintData()
        { 
            Console.WriteLine("Hello Name is { Name}");
        }
        public override String ToString()
        {
            return $"Hello! my Name is {Name}";

        }
        //Destructor
        ~Person()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int i=0;i<people.Length;i++)
            {
                Console.WriteLine($"Enter Name {i+1}");
                string name = Console.ReadLine();
                people[i] = new Person(name);
               
            }
           
           foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}