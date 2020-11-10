using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Scooter_Rental_Progect
{
    public static class TextWriterFactory
    {
        static TextWriter textWriter;
        /// <summary>
        /// Инициализация фейкового объекта, который не будет связан с файловой системой
        /// </summary> 
        /// <param name="MockWriter">Фейковый(Mock) объект</param>
        public static void SetTextWriter(TextWriter mockObject)
        {
            textWriter = mockObject; 
        }
        /// <summary>
        /// Создание нового потока для записи. Если это фейковый объект для тестирования
        /// возвращаем его, если же фейковый объект не инициализирован, возвращает экземпляр
        /// класса StremWriter
        /// </summary>
        /// <param name="path">Путь к файлу записи</param>
        /// <returns></returns>
        public static TextWriter GetTextWriter(string path)
        {
            if(textWriter != null)
            {
                return textWriter;
            }
            return new StreamWriter(path, true);
        }
    }
}
