using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooter_Rental_Progect
{
    public class ArgumentDaysException:Exception
    {
        int days;
        public int Days { get { return days; } }
        /// <summary>
        /// Исключительная ситуация - вызывается при инициализации колличества дней проката меньше нуля
        /// </summary>
        /// <param name="days"></param>
        public ArgumentDaysException(int days)
        {
            this.days = days;
        }
    }
}
