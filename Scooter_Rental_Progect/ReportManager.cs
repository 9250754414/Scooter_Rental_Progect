using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooter_Rental_Progect
{
    public static class ReportManager
    {
        /// <summary>
        /// Метод создания отчета об аренде для соответсвующего клиента, запись данных в файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="customer">Клиент</param>
        public static void CreateSimpleReport(string path, Customer customer)
        {
            TextWriter textWriter = TextWriterFactory.GetTextWriter(path);
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format($"Client report Name: {customer.Name}"));
            foreach (var rental in customer.Rentals)
            {
                strBuilder.AppendLine(string.Format($"Scooter rent Name: {rental.scooter.Name}, " +
                                                    $"Scooter type: {rental.scooter.type}, " +
                                                    $"Price rent coast: {rental.scooter.PriceRent}, " +
                                                    $"Days rent: {rental.Days}, " +
                                                    $"Total rent coast: {rental.CalculateDept().ToString()}"));


            }
            strBuilder.AppendLine(string.Format($"Total customer dept: {customer.CalculateDept().ToString()}"));
            textWriter.Write(strBuilder.ToString());
            textWriter.Flush();
        }
    }
}
