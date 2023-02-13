namespace A3___String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pi = Math.PI;
            var now = DateTime.Now;

            //Console.WriteLine($"|{pi,-10:N2}|");

            Console.WriteLine($"{now:M}");


            //Dates USE TODAY (DateTime.Now;

            //1 - January 22, 2019 (right aligned in a 40 character field)
            Console.WriteLine($"{now,40:MMMM d, yyyy}");
            

            //2 - 2019.01.22
            Console.WriteLine($"{now:yyyy.MM.dd}");


            //3 - Day 22 of January, 2019
            Console.WriteLine($"Day {now:dd} of {now:MMMM, yyyy}");


            //4 - Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year: {now:yyyy}, Month: {now:mm}, Day: {now:dd}");


            //5 -            Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"{now,10:dddd}");


            //6 -     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine($"{now,10:t}{now,10:dddd}");


            //7 - h:11, m:01, s:27
            Console.WriteLine($"h:{now.Hour}, m:{now.Minute}, s:{now.Second}");


            //8 - 2019.01.22.11.01.27
            Console.WriteLine($"{now:yyyy.MM.dd.}{now.Hour}.{now.Minute}.{now.Second}");


            // NUMBER TIME
            // If you have PI (3.1415) - use var pi = Math.PI;

            //1 - Output as currency
            Console.WriteLine($"{pi:C2}");


            //2 - Output as right-aligned (10 spaces), number with 3 decimal places
            Console.WriteLine($"|{pi,10:N3}|");


        }
    }
}
