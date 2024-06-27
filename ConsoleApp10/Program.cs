//Basic.Ketma - ketlik bo'limi uchun 2-amaliy vazifa

//1. Kalkulyator:

//Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.

//Input = 5;

//Input = +;

//Input = 5;

//Output = 10;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace praktikum_task1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("Birinchi raqamni kiriting: (input):");

            string a = Console.ReadLine();

            double a1 = Convert.ToDouble(a);

            Console.Write("Ikkinchi raqamni kiriting: (input):");

            string b = Console.ReadLine();

            double b1 = Convert.ToDouble(b);

            double summa = 0;

            Console.Write("operaciyani kiriting: (input):");

            string o = Console.ReadLine();

            switch (o)

            {

                case "+":

                    Console.WriteLine($"Qushish amali {summa = a1 + b1}"); break;

                case "-":

                    Console.WriteLine($"Ayirish amali {summa = a1 - b1}"); break;

                case "/":

                    Console.WriteLine($"Bulish amali {summa = a1 / b1}"); break;

                case "*":

                    Console.WriteLine($"Kupaytirish amali {summa = a1 * b1}"); break;

            }

        }

    }

}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//2.Raqamlar qatorining yig‘indisini hisoblash:

//Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab, natijani ekranga chiqaradigan dastur tuzing.

//Input = 10;

//Output = 55;

using System;

namespace praktikum_task1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write(" N  sonini kiriting: (input):");

            string N = Console.ReadLine();

            double N1 = Convert.ToInt32(N);

            int summa = 0;

            for (int i = 0; i <= N1; i++)

            {

                summa += i;

            }

            Console.WriteLine($"Summa :{summa}");

        }

    }

}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//3.Paritet tekshiruvi:

//Foydalanuvchi kiritgan raqamning juft yoki toq ekanligini aniqlaydigan va shunga mos ravishda xabarni chiqaradigan dastur tuzing.

//Input = 3;

//Output = “Toq”

namespace praktikum_task1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("N  sonini kiriting: (input):");

            string N = Console.ReadLine();

            double N1 = Convert.ToInt32(N);

            if (N1 % 2 == 0) Console.WriteLine("Kiritgan soningiz :Juft!");

            else Console.WriteLine("Kiritgan soningiz :Toq!");

        }

    }

}

