namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new() { 
            new("David","Jones",20000),
            new("Roger","Federer",20000),
            new("Novak","Djokovic",25000),
            new("Samantha","Jones",21000),
            new("Mika","Federer",19000),
            new("Kevin","De Bruyne",26000),
            new("Mike","Ross",19500),
            new("Jessica","Jones",20000)
            };

            Console.WriteLine("=======Before Sort======");
            Display(employees);
            BubbleSort(employees);
            Console.WriteLine("\n=======After Sort======");
            Display(employees);

        }

        private static void BubbleSort(List<Employee> strList)
        {
            for (int i = 0; i < strList.Count - 1; i++)
            {
                for (int j = (i + 1); j < strList.Count; j++)
                {
                    if (strList[i].CompareTo(strList[j]) > 0)
                    {
                        Employee temp = strList[i];
                        strList[i] = strList[j];
                        strList[j] = temp;
                    }
                }
            }
        }
        
        private static void Display(List<Employee> employees)
        {
            foreach (Employee em in employees)
            {
                Console.WriteLine(em.ToString());
            }
        }
    }
    public class Employee : IComparable<Employee>
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public double Salary { get; set; }
        public Employee(string firstname, string lastname, double sal) =>
            (Firstname, Lastname, Salary) = (firstname, lastname, sal);

        public override string? ToString()
        {   
            return $"{Firstname} {Lastname.ToUpper()} : {Salary.ToString("C2")}";
        }
           

        public int CompareTo(Employee? other)
        {
            int results = this.Salary.CompareTo(other.Salary);
            if (results == 0)
            {
                results = this.Firstname.CompareTo(other.Firstname);
            }
            return results;
        }
    }
}