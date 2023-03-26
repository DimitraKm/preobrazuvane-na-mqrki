namespace preobrazuvane_a_mqrki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string measures = Console.ReadLine().ToLower();
            int space = int.Parse(Console.ReadLine());
            double number = 0;

            if (measures == "miles")
            {
                number = space * 1.6;
                Console.WriteLine(number);
            }
            else if (measures == "inches")
            {
                number = space * 2.54;

            }
            else if (measures == "feet")
            {
                number = space * 30;

            }
            else if (measures == "yards")
            {
                number = space * 0.91;

            }
            else if (measures == "gallons")
            {
                number = space * 3.8;

            }


        }
    }
}