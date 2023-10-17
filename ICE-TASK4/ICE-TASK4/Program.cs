namespace ICE_TASK4
{
    internal class Program
    {
        static Dictionary<string, int> places = new();
        static void Main(string[] args)
        {
            places.Add("South Africa", -1);
            places.Add("Gauteng", 0);
            places.Add("Benoni", 1);
            places.Add("Pretoria", 1);
            places.Add("Cape Town", 5);
            places.Add("Western Cape", 0);
            places.Add("KZN", 0);
            places.Add("Midrand", 1);
            places.Add("Durban", 6);
            places.Add("Waterfall", 7);

            Console.Write("Enter a place: ");
            string place = Console.ReadLine();
            FindParent(place);

        }
        static void FindParent(string child)
        {
            int index = places[child];
            Console.WriteLine(child);
            if (index != -1 && index < places.Count)
            {
                FindParent(places.ElementAt(index).Key);
            }
        }
    }
}