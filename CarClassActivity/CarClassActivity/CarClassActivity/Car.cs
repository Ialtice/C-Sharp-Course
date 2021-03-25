using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarClassActivity
{
    class Car
    {
        private int year_model;
        private string make;
        private int speed;

        public Car(int inYear_model, string inMake)
        {
            year_model = inYear_model;
            make = inMake;
            speed = 0;
        }
        public void accelerate()
        {
            speed += 5;
        }
        public void brake()
        {
            speed -= 5;
        }
        public int current_speed()
        {
            return speed;
        }
    }
}
