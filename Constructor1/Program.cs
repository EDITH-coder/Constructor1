using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Car
    {
        public string Model;
        //constructor
        public Car(string model1) {
            this.Model = model1;
        }
        static void Main(string[] args)
        {
            //ask the user to enter a model
            Console.WriteLine("Enter a model");
            string model= Console.ReadLine();

            Console.WriteLine(" ");
            //created an object
            Car myCar = new Car(model);
            Console.WriteLine("The car model is: "+ myCar.Model);

            Console.ReadLine();

        }
    }
}
