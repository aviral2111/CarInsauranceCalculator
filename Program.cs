using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsauranceCalculator
{
    class PremiumCalulate
    {
                
        static void Main(string[] args)
        {

            double carprice, premium = 0;
            Console.Write("Enter Showroom Price of Car: ");
            carprice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Age of Car");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select Car Company:");
            Console.WriteLine("1) Honda");
            Console.WriteLine("2) TATA");
            Console.WriteLine("3) KIA");
            int company = Convert.ToInt32(Console.ReadLine());
            switch (company)
            {
                case 1:
                    {
                        premium = Honda(age,carprice);
                        break;
                    }
                case 2:
                    {
                        premium = Tata(age, carprice);
                        break;
                    }
                case 3:
                    {
                        premium = Kia(age, carprice);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action! try again");
                    break;
            }
            if (age < 2)
            {
                Console.WriteLine("The premium is {0}", premium);
            }
            else if (age >= 2 && age < 4)
            {
                Console.WriteLine("The premium is {0}", premium + 500);
            }
            else if (age >= 4 && age < 6)
            {
                Console.WriteLine("The premium is {0}", premium + 1000);
            }
            else if (age > 6)
            {
                Console.WriteLine("The premium is {0}", premium + 1500);
            }

            Console.ReadKey();
        }
        public static double Honda(int age, double carprice)
        {

            double premium = carprice * 6/100;
            return premium;
        }
        public static double Tata(int age, double carprice)
        {
            double premium = carprice * 5/100 ;
            return premium;
        }
        public static double Kia(int age, double carprice)
        {
            double premium = carprice * 3.4/100 ;
            return premium;
        }
    }
    
}
