using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Person pers1 = new Person("Moshe", "Davidov", 15,EnumPlayerType.OnlyOddPerson);
            Person pers2 = new Person("Dany", "Davidov", 2, EnumPlayerType.OnlyEvenPerson);
            Person pers3 = new Person("Alex", "Davidov", 22, EnumPlayerType.OnlyDivThrePerson);
            Person pers4 = new Person("Rahel", "Davidov", 44, EnumPlayerType.OnlyDivFourPerson);
            Person pers5 = new Person("Eva", "Davidov", 27, EnumPlayerType.OnlyDiveFive);
            Person pers6 = new Person("Noa", "Davidov", 23, EnumPlayerType.OnlyDivSix);

            List<Person> people = new List<Person>();
            people.Add(pers1);
            people.Add(pers2);
            people.Add(pers3);
            people.Add(pers4);
            people.Add(pers5);
            people.Add(pers6);



            Random random = new Random();
            for (int i = 0; i < 200; i++)
            {
                int value = random.Next(1, 7);

                if (value % 6 == 0)
                {
                    people.Where(x => x.EnumPlayerType == EnumPlayerType.OnlyEvenPerson || x.EnumPlayerType == EnumPlayerType.OnlyDivThrePerson
                                         || x.EnumPlayerType == EnumPlayerType.OnlyDivSix).ToList().ForEach(x => x.WinningCount++);
                }
                else if (value % 5 ==0)
                {
                    people.Where(x => x.EnumPlayerType == EnumPlayerType.OnlyDiveFive || x.EnumPlayerType == EnumPlayerType.OnlyOddPerson)
                                    .ToList().ForEach(x => x.WinningCount++);

                }
                else if (value % 4 == 0)
                {
                    people.Where(x => x.EnumPlayerType == EnumPlayerType.OnlyEvenPerson || x.EnumPlayerType == EnumPlayerType.OnlyDivFourPerson).ToList().ForEach(x => x.WinningCount++);

                }
                else if (value % 3 == 0)
                {
                    people.Where(x => x.EnumPlayerType == EnumPlayerType.OnlyDivThrePerson || x.EnumPlayerType == EnumPlayerType.OnlyOddPerson).ToList().ForEach(x => x.WinningCount++);

                }
                else if (value % 2 == 0)
                {
                    people.Where(x => x.EnumPlayerType == EnumPlayerType.OnlyEvenPerson ).ToList().ForEach(x => x.WinningCount++);

                }



            }

            people.ForEach(x => Console.WriteLine(x));



            Console.ReadKey();

        }
    }
}
