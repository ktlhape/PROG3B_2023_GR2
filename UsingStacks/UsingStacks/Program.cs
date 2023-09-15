namespace UsingStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "today is tuesday";
            string reverseWords = "";
            Stack<char> stk = new();

            for (int i =  0; i < words.Length; i++)
            {
                stk.Push(words[i]); //y
                
            }

            foreach (char c in stk)
            {
                reverseWords += c;
            }

            Console.WriteLine(reverseWords);

        }
    }
}