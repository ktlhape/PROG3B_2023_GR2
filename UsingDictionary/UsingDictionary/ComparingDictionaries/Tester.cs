using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary.ComparingDictionaries
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            /*  012 - Pretoria
                011 - Johannesburg
                031 - Durban
                014 - Rustenburg
                016 - Vereeniging
                021 - Cape Town
                018 - Potchefstroom
                057 - Welkom
             */
            Dictionary<string, string> areaCodes = new();
            Dictionary<string, string> userAreaCodes = new();
            //Original 
            areaCodes.Add("011", "Johannesburg");
            areaCodes.Add("031", "Durban");
            areaCodes.Add("014", "Rustenburg");
            areaCodes.Add("021", "Cape Town");
            areaCodes.Add("018", "Potchefstroom");

            //User answers
            userAreaCodes.Add("014", "Rustenburg");
            userAreaCodes.Add("011", "Johannesburg");
            userAreaCodes.Add("021", "Cape Town");
            userAreaCodes.Add("018", "Potchefstroom");
            userAreaCodes.Add("031", "KZN");

            Random rnd = new Random();
            areaCodes = areaCodes.OrderBy(c => rnd.Next())
                .ToDictionary(codes => codes.Key, codes => codes.Value);

            Display(areaCodes);

            int count = 0;
            //Check for correct answers
            foreach (KeyValuePair<string,string> codes in areaCodes)
            {                                   //011               //Johannesburg
                if (userAreaCodes.TryGetValue(codes.Key, out string area))
                {
                    if (codes.Value.Equals(area))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Count: {count}");
            Console.Read();
        }
        private static void Display(Dictionary<string, string> areaCodes)
        {
            foreach (KeyValuePair<string,string> codes in areaCodes)
            {
                Console.WriteLine(codes);
            }
        }
    }
}
