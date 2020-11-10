using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooter_Rental_Progect
{
    public class Customer
    {
        List<Rental> rentals = new List<Rental>();
        public List<Rental> Rentals { get { return rentals; } }
        string name;
        public string Name { get { return name; } }
        /// <summary>
        /// Конструктор создания клиента
        /// </summary>
        /// <param name="name">Имя клиента</param>
        public Customer(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Подсчет суммы долга по всем скуторам в аренде у клиента
        /// </summary>
        /// <returns></returns>
        public double CalculateDept()
        {
            double sum = 0;
            if(rentals != null)
            {
                foreach(var k in rentals)
                {
                    sum += k.CalculateDept();
                }
            }
            return sum;
        }
    }
}
