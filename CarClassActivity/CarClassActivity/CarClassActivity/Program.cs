//Student: Isaac Altice
// ID # : 801077284
//Car Activity
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarClassActivity
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int inYear_Model = 2020; ;
            string inMake = "Nissan";
            Console.WriteLine("Enter the Car's Year Model: ");
            try
            {
               inYear_Model = Int32.Parse(Console.ReadLine());
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("{0} Exception.", e);
                Console.WriteLine("Invalid Model year entered, using default of 2020");
            }
            Console.WriteLine("Enter the Car's Make: ");
            try
            {
                inMake = Console.ReadLine();
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("{0} Exception.", e);
                Console.WriteLine("Invalid make entered, using default of Nissan");
            }
            Car car1 = new Car(inYear_Model, inMake);
            Console.WriteLine("Accelerating.");
            for(int i = 0; i < 5; i++)
            {
                car1.accelerate();
                Console.WriteLine("Current Speed : " + car1.current_speed());
            }
            Console.WriteLine("Braking.");
            for (int i = 0; i < 5; i++)
            {
                car1.brake();
                Console.WriteLine("Current Speed : " + car1.current_speed());
            }
            Console.ReadLine();
        }
    }
}
