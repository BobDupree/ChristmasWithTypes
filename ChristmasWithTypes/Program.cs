using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var ChanukahDay = Christmas.Day.Thursday;

     
            xmas.Tzadik = "The Rebbe";

           
            xmas.Presents =  new string[3]{"chocolate coins", "dreidels", "one million dollars" }; 

            
            xmas.MenorahHeight = 5;

            Console.WriteLine($"This year Chanukah falls on {ChanukahDay} \n");
            Console.WriteLine($"Our menorah will be {xmas.MenorahHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to learn from {xmas.Tzadik}");
        }
    }
}
