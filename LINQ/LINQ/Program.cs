using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
   public class Program
    {
       public static void Main()
        {
            Random rand = new Random();
            Note[] notes = new Note[100];
            for (int i = 0; i < 100; i++)
            {
                notes[i] = new Note(GenerateString(rand,7), i + 1, GenerateDate(rand));
            }
        restart: try
            {
                Console.Write("Введите дату для поиска по заметкам:\nДень:");
                int day = Convert.ToInt16(Console.ReadLine());
                Console.Write("Месяц: ");
                int month = Convert.ToInt16(Console.ReadLine());
                Console.Write("Год: ");
                int year = Convert.ToInt16(Console.ReadLine());

                if (day > 31 || month > 12 || year > 2021)
                {
                    throw new FormatException();
                }
                DateTime dateFilter = new DateTime(year, month, day);

                var selectedNotes = from note in notes
                                    where note.Date.ToShortDateString() == dateFilter.ToShortDateString()
                                    select note;

                Console.WriteLine("Все заметки за {0}:",dateFilter.ToShortDateString());
                foreach (var note in selectedNotes)
                {
                    Console.WriteLine(note.ToString());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорректные данные!");
                goto restart;
            }

            var selectedNotes2 = from note in notes
                                where note.SerialNumber<10
                                orderby note.Text
                                select note;

            Console.WriteLine("\n\nПервые 10 заметок в алфавитном порядке: ");
            foreach (var note in selectedNotes2)
            {
                Console.WriteLine(note.ToString());
            }

            var sumSeriesNumbers = notes.Sum(note => note.SerialNumber);
            Console.WriteLine("\n\nСумма порядковых номеров всех ста заметок: {0}",sumSeriesNumbers);

            var minDate = notes.Min(note => note.Date);
            var maxDate = notes.Max(note => note.Date);
            Console.WriteLine("\n\nСамая старая запись: {0}\nСамая новая запись: {1}", minDate.ToShortDateString(),maxDate.ToShortDateString());

            Console.WriteLine("\nСортируем по дате:");
            var noteGroups = from note in notes
                             orderby note.Date
                              group note by note.Date;

            foreach (IGrouping<DateTime, Note> note in noteGroups)
            {
                Console.WriteLine(note.Key.ToShortDateString());
                foreach (var n in note)
                    Console.WriteLine(n.ToString());
                Console.WriteLine();
            }

            bool result1 = notes.All(note => note.Date.Month == 2);
            bool result2 = notes.Any(note => note.Date.Month == 3);
            if (result1)
            {
                Console.WriteLine("Все записи сделаны в феврале.");
            }
            else
            {
                Console.WriteLine("Не все записи сделаны в феврале.");
                if (result2)
                {
                    Console.WriteLine("Некоторые записи сделаны в марте.");
                }
            }

            Console.ReadLine();
        }

        public static char GenerateChar(Random rng)
        {
            return (char)(rng.Next('a', 'z' + 1));
        }

        public static string GenerateString(Random rng, int length)
        {
            char[] letters = new char[length];
            for (int i = 0; i < length; i++)
            {
                letters[i] = GenerateChar(rng);
            }
            return new string(letters);
        }

        public static DateTime GenerateDate(Random rnd)
        {
            DateTime start = new DateTime(2021, 2, 1);
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(rnd.Next(range));
        }

    }
}
