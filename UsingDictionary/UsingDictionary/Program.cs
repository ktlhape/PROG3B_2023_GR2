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
            using (StreamReader reader = new StreamReader("departments.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lines = line.Split(new char[] { ',' });
                    string dep = lines[0]; //HR
                    List<string> names = new List<string>();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        names.Add(lines[i]);
                    }
                    departments.Add(dep, names);
                }
            }
       
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