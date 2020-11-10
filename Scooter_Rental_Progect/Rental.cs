using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooter_Rental_Progect
{
    public class Rental
    { 
        public Scooter scooter;
        int days;
        /// <summary>
        /// Дни проката. Если колличество дней проката окажется меньше нуля, 
        /// появиться исключение типа ArgumentDaysException
        /// </summary>
        public int Days
        {
            get { return days; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentDaysException(value);
                }
                days = value;
            }
        }
        /// <summary>
        /// Конструктор Аренды
        /// </summary>
        /// <param name="scooter">Скутер</param>
        /// <param name="days">Дни проката</param>
        public Rental(Scooter scooter, int days)
        {
            if (days < 0)
            {
                throw new ArgumentDaysException(days);
            }
            this.scooter = scooter;
            this.days = days;
        }
        /// <summary>
        /// Подсчет суммы долга за аренду(Цена проката * колличество дней проката)
        /// </summary>
        /// <returns></returns>
        public double CalculateDept()
        {
            return scooter.PriceRent * days;
        }
        /// <summary>
        /// Добавление дней проката
        /// </summary>
        /// <param name="days">По умолчанию можно добавить 1 день(или указать необходимое число)</param>
        public void AddDays(int days = 1)
        {
            Days += days;
        }
        /// <summary>
        /// Удаление дней проката
        /// </summary>
        /// <param name="days">По умолчанию можно удалить 1 день(или указать необходимое число)</param>
        public void SubtractionDays(int days = 1)
        {
            Days -= days;
        }
    }
}
