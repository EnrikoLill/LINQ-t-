using ConsoleApp1;
using System;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");
            WhereLINQ();
            SkipWhileLINQ();

        }

        public static void WhereLINQ()
        {   // näitab kõiki 10 kuni 22 vanuse vahemikus
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 10 && x.Age < 22);
            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void SkipWhileLINQ()
        {

            Console.WriteLine("----------SkipWhile--------------");
            //näitab kõiki, kellel on neli või vähem tähemärki 
            var skipWhile = PeopleList.peoples.SkipWhile(s => s.Name.Length > 4);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
