namespace UsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Create a dictionary that will store departments
             and the list of employees in each department
            
             HR,FINANCE,IT*/
            Dictionary<string, List<string>> departments = new();
            //Add items
            departments.Add("HR", new() { "David", "Carol", "Kabelo" });
            departments.Add("IT", new() { "Jessica", "Thabo", "Mike", "Roger" });
            departments.Add("FIN", new() { "Smith", "Caroline" });

            //Acces data
            List<string> hrList = departments["HR"];
            //Display
            int count = 0;
            char c = 'A';
            foreach (string dep in departments.Keys)
            {
                Console.Write($"{c++}. {dep}");

                foreach (string employee in departments[dep])
                {
                    Console.WriteLine($"\t{++count}. {employee}");
                }
                count = 0;
            }

            
        }
    }
}