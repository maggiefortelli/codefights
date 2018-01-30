using System;

namespace centuryFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(args[0]);
            Console.WriteLine(GetCentury(year));
        }

        /* Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, 
           the second - from the year 101 up to and including the year 200, etc.*/
        internal static int GetCentury(int year){
            double siglo = year/100.0;
            Console.WriteLine("Siglo: "+ siglo);
            int sigloRedondeado = year / 100;
            Console.WriteLine("Siglo redondeado: " + sigloRedondeado);

            if(siglo == sigloRedondeado)
                return sigloRedondeado;
            else if(siglo > sigloRedondeado){
                return sigloRedondeado + 1;
            }        
            else{
                return 0;
            }
        }
    }
}
