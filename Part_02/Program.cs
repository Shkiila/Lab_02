using System.ComponentModel.DataAnnotations;

namespace part2
{
    public class Program
    {
        static void Main()
        {
            int x = 1, y = 2, seat1 = 3, seat2 = 4, year1 = 1997, year2 = 2019, year3 = 2004;
            double p1 = 1005.2, p2 = 2000, p3 = 800.99, sp1 = 123, sp2 = 234, sp3 = 345, ht = 1234.5;
            string st = "RND";

            Ship sh1 = new Ship(x, y,year1, seat1, st,p1, sp1);
            Car cr1 = new Car(x, y, year2, p2, sp2);
            Plane pl1 = new Plane(x, y, year3, seat2, ht, p3, sp3);

            sh1.GetInfo();
            cr1.GetInfo(); 
            pl1.GetInfo();
        }

        public class Car : Vehicle
        {
            int x, y, year;
            double price, speed;

            public Car(int x, int y, int year, double price, double speed) : base(x, y, year, price, speed)
            {
              
            }
            public override void GetInfo()
            {
                Console.WriteLine("Type - Car.");
                base.GetInfo();
            }
        }
        public class Ship : Vehicle
        {
            int x, y, year, seats;
            double price, speed;
            string home;

            public Ship(int x, int y, int year, int seats, string home, double price, double speed) : base(x, y, year, price, speed)
            {
                this.seats = seats;
                this.home = home;
            }
            public override void GetInfo()
            {
                Console.WriteLine("Type - Ship.");
                base.GetInfo();
            }
        }
        public class Plane : Vehicle
        {
            int x, y, year, seats;
            double price, speed, height;

            public Plane(int x, int y, int year, int seats, double height, double price, double speed) : base(x, y, year, price, speed)
            {
                this.seats = seats;
                this.height = height;
            }
            public override void GetInfo()
            {
                Console.WriteLine("Type - Plane.");
                base.GetInfo();

            }
        }
         public class Vehicle
        {
            int x, y, year;
            double price, speed;

            public Vehicle (int x, int y, int year, double price, double speed)
            {
                this.x = x;
                this.y = y;
                this.year = year;
                this.price = price;
                this.speed = speed;
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"x - {this.x}.\ny - {this.y}.\nYear of issue - {this.year}.\nPrice - {this.price}.\nMax speed - {this.speed}.");
            }
        }
    }
}