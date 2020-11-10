using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooter_Rental_Progect
{
    public class Scooter
    { 
        string name;
        double priceRent;
        public ScooterType type;
        public double PriceRent { get { return priceRent; } }
        public string Name { get { return name; } }
        /// <summary>
        /// Конструктор для создания скутера
        /// </summary>
        /// <param name="name">Имя скутера</param>
        /// <param name="priceRent">Цена аренды в сутки</param>
        /// <param name="type">Тип скутера</param>
        public Scooter(string name, double priceRent, ScooterType type)
        {
            this.name = name;
            this.priceRent = priceRent;
            this.type = type;

        }
        /// <summary>
        /// Аренда скутера Сузуки
        /// </summary>
        /// <param name="name">Имя скутера</param>
        /// <returns></returns>
        public static Scooter Suzuki(string name)
        {
            return new Scooter(name, 5, ScooterType.Suzuki);
        }
        /// <summary>
        /// Аренда скутера Хонда
        /// </summary>
        /// <param name="name">Имя скутера</param>
        /// <returns></returns>
        public static Scooter Honda(string name)
        {
            return new Scooter(name, 7, ScooterType.Honda);
        }
        /// <summary>
        /// Аренда скутера Ямаха
        /// </summary>
        /// <param name="name">Имя скутера</param>
        /// <returns></returns>
        public static Scooter Yamaha(string name)
        {
            return new Scooter(name, 10, ScooterType.Yamaha);
        }
        /// <summary>
        /// Аренда скутера БМВ
        /// </summary>
        /// <param name="name">Имя скутера</param>
        /// <returns></returns>
        public static Scooter BMW(string name)
        {
            return new Scooter(name, 12, ScooterType.BMW);
        }
    }
}
