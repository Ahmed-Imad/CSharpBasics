using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.CarName);

            List <Phone> phones = new List <Phone>();
            phones.Add(new CellPhone());
            phones.Add(new SmartPhone());
            
            foreach (var  phone in phones)
            {
                if (phone is CellPhone cell) 
                {
                    Console.WriteLine(phone.);
                }
        }
    }
}
