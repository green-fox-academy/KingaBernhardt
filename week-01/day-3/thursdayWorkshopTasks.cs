using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int codingHours = 6;
            int lenghtOfSemester = 17;
            int workHours = 52;
            Console.WriteLine(codingHours * lenghtOfSemester);
            Console.WriteLine(workHours*lenghtOfSemester%100);
            Console.ReadLine();

        }
    } 
}

using System;

namespace FavouriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFavouriteNumber = 9;
            Console.WriteLine("My favourite number is: " + myFavouriteNumber);
            Console.WriteLine("My favourite number is: {0} ", myFavouriteNumber);
            Console.ReadLine();

        }
    }
}

using System;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}

using System;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Kinga";
            int myAge = 25;
            double myHeight = 1.8;
            bool myStatus = true;
            string status = "";

            if (myStatus == true)
            {
                status = "married";
            }
            else
            {
                status ="not married";
            }

            Console.WriteLine("I am {0} a {1} years old {2} height and I am {3}" , myName, myAge, myHeight, status);
            Console.ReadLine();
        }
    }
}

using System;

namespace variablemutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine(a+10);

            int b = 100;
            Console.WriteLine(b-7);

            int c = 44;
            Console.WriteLine(c*2);

            int d = 125;
            Console.WriteLine(d%5);

            int e = 8;
            Console.WriteLine(e*e*e);

            int f1 = 123;
            int f2 = 345;

            if (f1 > f2)
            {
            Console.WriteLine("True");
            } else
            {
            Console.WriteLine("False");
            }
     
            int g1 = 350;
            int g2 = 200;
            if (g2 > g1)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }

            int h = 135798;

            if (h%11==0)
            {
                Console.WriteLine("It has 11 as a divisor.");
            } else
            {
                Console.WriteLine("It can not divided by 11.");
            }
            int i1 = 10;
            int i2 = 3;
            if (i1>i2*i2 && i1>i2*i2*i2)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }
            int j = 1521;
            if (j%5==0)
            {
                Console.WriteLine("Divided by 5.");
            } else if (j%3==0)
            {
                Console.WriteLine("Divided by 3.");
            }
            string k = "Apple";
            k = k + k + k + k;
            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}

using System;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 81.2;
            double heightInM = 1.78;
            double answer = massInKg / heightInM;

            Console.WriteLine(answer / heightInM);
            Console.ReadLine();
        }          
    }
}

using System;

namespace secondinapage
{
    class Program
    {
        static void Main(string[] args)
        {
        double aSide = 5;
        double bSide = 4;
        double cSide = 10;
        double surfaceArea = 2 * aSide + 2 * bSide + 2 * cSide;
            double volume = aSide * bSide * cSide;
            Console.WriteLine(surfaceArea);
            Console.WriteLine(volume);
            Console.ReadLine();


        }
    }
}

using System;

namespace secondsleftinaday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }
    }
}

using System;

namespace mileandkm
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceKm = 25;

            double distanceMiles = distanceKm/0.62137119;

            Console.WriteLine(distanceMiles);
            Console.ReadLine();
        }
    }
}

using System;

namespace secondoftheday
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 23;
            int currentMinutes = 59;
            int currentSeconds = 50;

            int secInADay = 24 * 60 * 60;
            
            int secLeftADay = secInADay - currentHours * 60 * 60 - currentMinutes * 60 - currentSeconds;
            Console.WriteLine(secLeftADay);
            Console.ReadLine();
        }
    }
}

using System;

namespace chickens
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickens = 6;
            int pigs = 5;
            int legsOfAnimals = chickens * 2 + pigs * 4;

            Console.WriteLine(legsOfAnimals);
            Console.ReadLine();
        }
    }
}

using System;

namespace averageInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 7;
            int c = 3;
            int d = 5;
            int e = 10;
            int sumOfNumbers = a + b + c + d + e;
            int averageOfNumbers = sumOfNumbers / 5;
            Console.WriteLine(sumOfNumbers);
            Console.WriteLine(averageOfNumbers);
            Console.ReadLine();
        }
            
    }
}

using System;

namespace theOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4;
            if (a%2==0)
            {
                Console.WriteLine("Even");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Odd");
                Console.ReadLine();
            }
            
        }
    }
}

using System;

namespace numbercomparesifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            if (a <= 0)
            {
                Console.WriteLine("Not enough");
            } else if ( a == 1)
            {
                Console.WriteLine("One");
            } else if ( a == 2)
            {
                Console.WriteLine("Two");
            } else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace thebiggerone
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 29;
            double b = 12;
            if (a<b)
            {
                Console.WriteLine(b);
            } else
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace partyifstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int girlsOnParty = 3;
            int boysOnParty = 18;
            if (girlsOnParty == boysOnParty && girlsOnParty + boysOnParty > 20)
            {
                Console.WriteLine("The party is excellent");
            }
            else if (girlsOnParty + boysOnParty > 20 && girlsOnParty != boysOnParty)
            {
                Console.WriteLine("Quite cool party");
            } else if (girlsOnParty+boysOnParty<20)
            {
                Console.WriteLine("Average party");
            } else if (girlsOnParty==0)
            {
                Console.WriteLine("Sausage party");
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace conditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int out1 = 1;

            if (a%2==0)
            {
                out1 = out1+1;
                Console.WriteLine(out1);
            } else
            {
                Console.WriteLine(out1);
            }

            int b = 5;
            string out2 = "";

            if (b>10 && b < 20)
            {
                out2 = "sweet";
                Console.WriteLine(out2);
            } else if (b<10)
            {
                out2 = "less";
                Console.WriteLine(out2);
            } else
            {
                out2 = "More";
                Console.WriteLine(out2);
            }

            int c = 20;
            int credits = 40;
            bool isBonus = false;

            if (credits >= 50 && isBonus == false)
            {
                c = c - 2;
                Console.WriteLine(c);
            } else if (credits < 50 && isBonus ==false)
            {
                c= c-1;
                Console.WriteLine(c);
            } else if (isBonus == true)
            {
                Console.WriteLine(c);
            }

            int d = 8;
            int time = 220;
            string out3 = "";
            if (d/4==0 && time <= 200)
            {
                out3 = "check";
                Console.WriteLine();
            } else if (time > 200)
            {
                out3 = "Time out!";
                Console.WriteLine(out3);
            } else
            {
                out3 = "Run Forest Run";
                Console.WriteLine(out3);
            }
            Console.ReadLine();
        }
    }
}
