using System;

namespace airplane_lighting
{
    class Program
    {
        static void Main(string[] args)
        {
            var Boeing = new Plane()
            {
                Model = "139 privet",
                Make = "Boeing",
                Seats = 20,
            };

            Boeing.Fly();
        }

        class Plane
        {


            public string Make { get; set; }

            public string Model { get; set; }

            public double Seats { get; set; }

            public void Fly()
            {
                Console.WriteLine($"{Model}: Fly for me because it's mine!");
                Console.WriteLine($"{Make}: Made by Deep co.");
                Console.WriteLine($"{Seats}: luxurios seats");
            }

        }


    }
}
