using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreds k1 = new Kreds("1", "Kurt", "vej 22", 4);
            Kreds k2 = new Kreds("2", "Marianne", "vej 22", 5);
            Kreds k3 = new Kreds("3", "Bob", "vej 22", 6);

            Console.WriteLine("Velkommen til Landslejeren!.");
            Console.WriteLine();

            Console.WriteLine("3 styks kredse:");
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            Console.WriteLine(k3);
            Console.WriteLine();

            Badetidsperiode b1 = new Badetidsperiode("Morgenbadning", DayOfWeek.Sunday, new DateTime().AddYears(2014).AddDays(07).AddMonths(05).AddHours(06).AddMinutes(35), new DateTime().AddYears(2014).AddDays(07).AddMonths(05).AddHours(07).AddMinutes(35));
            Badetidsperiode b2 = new Badetidsperiode("Eftermiddagsbadning", DayOfWeek.Sunday, new DateTime(2015, 06, 08, 13, 45, 00), new DateTime(2015, 06, 08, 14, 45, 00));
            b1.AdderKreds(k1);
            b1.AdderKreds(k2);
            Console.WriteLine(b1);
            Console.WriteLine();

            b2.SletKreds("3");
            Console.WriteLine(b2);
            Console.WriteLine();
            Console.WriteLine("Det er alle kredse og badetider." + " Hav en god dag!!");

            Console.ReadLine();
        }
    }
}
