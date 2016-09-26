using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class ContacCar
    {
        public Car Car { get; set; }
        public Person Person { get; set; }

        public ContacCar(Car car, Person person)
        {
            Car = car;
            Person = person;
        }

        public void DynamicPrint()
        {
            dynamic objet = Person;
            System.Console.WriteLine(objet.Print() + " voiture : " + Car.ToString());
        }
    }
}
