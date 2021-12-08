using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Integer1();
            Integer2();
            Integer3();
            Integer4();
            Integer30();
            Integer27();
            Integer28();
            Integer29();
            Integer26();
            Integer25();
            Integer24();
            Integer23();
            Integer22();
            Integer21();
            Integer20();
            Integer19();
            Integer18();
            Integer17();
            Integer16();
            Integer15();
            Integer14();
            Integer13();
            Integer12();
            Integer11();
            Integer9();
            Integer8();
            Integer7();
            Integer6();*/
            Integer5();

        }
        static void Integer1()
        {
            Console.WriteLine("Vvedi cm");
            int l = int.Parse(Console.ReadLine());
            int lInMeters = l / 100;
            Console.WriteLine(lInMeters + " eto perevedeno v metru");
        }
        static void Integer2()
        {
            int m = int.Parse(Console.ReadLine());
            int mInTonns = m / 1000;
            Console.WriteLine(mInTonns);
        }
        static void Integer3()
        {
            int B = int.Parse(Console.ReadLine());
            int kB = B / 1024;
            Console.WriteLine(kB);
        }
        static void Integer4()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int BInA = A / B;
            Console.WriteLine(BInA);
        }
        static void Integer10()
        {
            int num = int.Parse(Console.ReadLine());
            int lastNum = num % 10;
            int secNum = (num / 10) % 10;
            Console.WriteLine(lastNum);
            Console.WriteLine(secNum);
        }
        static void Integer30()
        {
            int year = int.Parse(Console.ReadLine());
            int stolletie;
            if (year % 100 == 0)
            {
                stolletie = year / 100;
            }
            else
            {
                stolletie = (year / 100) + 1;
            }
            Console.WriteLine(stolletie);
        }
        static void Integer27()
        {
            int k = int.Parse(Console.ReadLine());
            int denbNedeli = ((k + 4)%7)+1;
            Console.WriteLine(denbNedeli);
        }
        static void Integer28()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            n = n - 2;
            int denbNedeli = (k + n) % 7 + 1;
            Console.WriteLine(denbNedeli);
        }
        static void Integer29()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int cube = (a * b) / (c * c);
            Console.WriteLine(cube);
            int freecube = (a * b) % c * c;
            Console.WriteLine(freecube);

        }
        static void Integer26()
        {
            int k = int.Parse(Console.ReadLine());
            int denbNedeli = ((k) % 7) + 1;
            Console.WriteLine(denbNedeli);
        }
        static void Integer25()
        {
            int k = int.Parse(Console.ReadLine());
            int denbNedeli = ((k + 3) % 7);
            Console.WriteLine(denbNedeli);
        }
        static void Integer24()
        {
            int k = int.Parse(Console.ReadLine());
            int denbNedeli = k % 7;
            Console.WriteLine(denbNedeli);
        }
        static void Integer23()
        {
            int N = int.Parse(Console.ReadLine());
            int minFromLastHour = N %3600/ 60;
            Console.WriteLine(minFromLastHour);
        }
        static void Integer22()
        {
            int N = int.Parse(Console.ReadLine());
            int secFromLastHour = N % 3600;
            Console.WriteLine(secFromLastHour);
        }
        static void Integer21()
        {
            int N = int.Parse(Console.ReadLine());
            int secFromLastMin = N % 60;
            Console.WriteLine(secFromLastMin);
        }
        static void Integer20()
        {
            int N = int.Parse(Console.ReadLine());
            int hourFromLastDay = (N / 60 / 60) % 24;
            Console.WriteLine(hourFromLastDay);
        }
        static void Integer19()
        {
            int N = int.Parse(Console.ReadLine());
            int minFromLastDay = (N / 60) % 1440;
            Console.WriteLine(minFromLastDay);
        }
        static void Integer18()
        {
            int moreThanNine = int.Parse(Console.ReadLine());
            int IZero = moreThanNine % 10000 / 1000;
            Console.WriteLine(IZero);
        }
        static void Integer17()
        {
            int moreThanNine = int.Parse(Console.ReadLine());
            int IZero = moreThanNine % 1000 / 100;
            Console.WriteLine(IZero);
        }
        static void Integer16()
        {
            int abc = int.Parse(Console.ReadLine());
            int acb = (abc / 100) * 100 + (abc % 10) * 10 + (abc % 100 / 10);
            Console.WriteLine(acb);
        }
        static void Integer15()
        {
            int abc = int.Parse(Console.ReadLine());
            int bac = (((abc / 10) % 10) * 100) + ((abc / 100) * 10) + (abc % 10);
            Console.WriteLine(bac);
        }
        static void Integer14()
        {
            int abc = int.Parse(Console.ReadLine());
            int cab = (abc / 10) + (abc % 10 * 100);
            Console.WriteLine(cab);
        }
        static void Integer13()
        {
            int abc = int.Parse(Console.ReadLine());
            int bca = (abc % 100 * 10) + (abc / 100);
            Console.WriteLine(bca);
        }
        static void Integer12()
        {
            int abc = int.Parse(Console.ReadLine());
            int cba = (abc / 100) + (abc % 10 * 100) + (abc / 10 % 10 * 10);
            Console.WriteLine(cba);
        }
        static void Integer11()
        {
            int abc = int.Parse(Console.ReadLine());
            int sum = (abc / 100) + (abc % 10) + (abc / 10 % 10);
            Console.WriteLine(sum);
            Console.Write("A chto takoe proizvedenie ya ne znau, esli eto ymnozhenie, to vot: ");
            int proizvedenie = (abc / 100) * (abc % 10) * (abc / 10 % 10);
            Console.Write(proizvedenie);
            Console.WriteLine();
        }
        static void Integer9()
        {
            int abc = int.Parse(Console.ReadLine());
            int c = abc / 100;
            Console.WriteLine(c);
        }
        static void Integer8()
        {
            int ab = int.Parse(Console.ReadLine());
            int ba = (ab / 10) + (ab % 10 * 10);
            Console.WriteLine(ba);
        }
        static void Integer7()
        {
            int ab = int.Parse(Console.ReadLine());
            int sum = (ab / 10) + (ab % 10);
            Console.WriteLine("Sum: " + sum);
            int proizvedenie = (ab / 10) * (ab % 10);
            Console.WriteLine("Ya tak i ne ponyal chto takoe proizvedenie, esli eto ymnozhenie, to vot: " + proizvedenie);
        }
        static void Integer6()
        {
            int ab = int.Parse(Console.ReadLine());
            int a = ab / 10;
            Console.WriteLine(a);
            int b = ab % 10;
            Console.WriteLine(b);
        }
        static void Integer5()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int ostatok = A % B;
            Console.WriteLine(ostatok);
        }
    }
}
