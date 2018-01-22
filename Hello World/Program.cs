using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
           
            String messageOne = "Hello World";
            String messageTwo = "I am Spartacus";
            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            Console.WriteLine(messageOne);
            Console.WriteLine(messageTwo);
            Console.WriteLine(ageOne + ageTwo);
            Console.WriteLine(heightOne - heightTwo);
            Console.WriteLine(weightOne * weightTwo);
            Console.WriteLine(isGodLikeOne);
            Console.WriteLine(genderMale);

            ageTwo = 70;
            heightTwo = 35.12345f;
            weightTwo = -429.1234573f;

            Console.WriteLine(ageOne + ageTwo);
            Console.WriteLine(heightOne + heightTwo);
            Console.WriteLine(weightOne * weightTwo);
            Console.WriteLine(ageTwo / ageOne);
            Console.WriteLine(ageTwo % ageOne);
            Console.WriteLine(ageThree / ageOne);
            Console.WriteLine(ageThree % ageOne);

            ageTwo++;
            Console.WriteLine(ageTwo);
            ageTwo--;
            Console.WriteLine(ageTwo);

            Console.WriteLine("5" == "5");
            Console.WriteLine(40 != 40);
            Console.WriteLine(11 < 4);

           






        }
    }
}
