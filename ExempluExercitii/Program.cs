using System;

namespace ExempluExercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Cele doua forward slash "//" in fata unei linii de cod marcheaza linia ca fiind comentata iar instructiunile de pe linie nu vor fi rulate.
            // Acum va rula exercitiu 2
            // Pentru a rula exercitiul 1 vom sterge "//" din fata liniei 12, "//Ex1" si vom comenta linia 13 adaugand "//" in fata textului "Ex2"

            Ex1();
            //Ex2();
            //Ex3();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();
            //Ex9();
            //Ex10();

            // Sa nu uitati sa salvati in mod frecvent (Ctrl+S) pentru a nu pierde munca
            Console.ReadLine();
        }
        static  void Ex1()
        {
            /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            paralelipiped dreptunghic, va afisa volumul lui*/

            Console.WriteLine("Introduceti lungimea");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latimea");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea");
            int inaltime = int.Parse(Console.ReadLine());

            int volumulParalelipipedului = lungime * latime * inaltime;

            Console.WriteLine("Volumul paralelipipedului este " + volumulParalelipipedului);

        }
        static void Ex2()
        {
            // Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura

            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            int z = int.Parse(Console.ReadLine());

            int mediaAritmetica = (x + y + z) / 3;

            Console.WriteLine("Media aritmetica a numerelor este " + mediaAritmetica);
        }
        static void Ex3()
        {
            // Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura
            Console.WriteLine("Introduceti numarul ");
            int numarul = int.Parse(Console.ReadLine());

            int ultimaCifra = numarul % 10;

            Console.WriteLine("ultima cifra a numarului este " + ultimaCifra);
        }
        static void Ex4()
        {
            // Scrieti un program care va afisa semnul unui numar citit de la tastatura
            //   • Daca numarul este pozitiv, va afisa “+”
            //   • Daca numarul este negativ, va afisa “-”
            //   • Daca numarul este 0, va afisa “0”

            Console.WriteLine("Introduceti numarul ");
            int numarul = int.Parse(Console.ReadLine());

            if (numarul > 0)
            {
                Console.WriteLine("+");
            }
            else if (numarul < 0)
            {
                Console.WriteLine("-");
            }
            else 
            {
                Console.WriteLine("0");
            }

        }
        static void Ex5()
        {
            // Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            if (x>y)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            else 
            {
                Console.WriteLine(y);
                Console.WriteLine(x);
            }
        }
        static void Ex6()
        {
            // Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.

            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Numerele ordonate");
            if (x > y)
            {                
                if (z > x)
                {
                    //zxy
                    Console.WriteLine(z);
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }else if (y > z)
                {
                    //xyz
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                    Console.WriteLine(z);
                }
                else
                {
                //xzy
                    Console.WriteLine(x);
                    Console.WriteLine(z);
                    Console.WriteLine(y);
                }            
            }
            else {
                if (z > y)
                {
                    //zyx
                    Console.WriteLine(z);
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
                else if (x>z)
                {
                    //yxz
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                    Console.WriteLine(z);
                }
                else
                {
                    //yzx
                    Console.WriteLine(y);
                    Console.WriteLine(z);
                    Console.WriteLine(x);
                }
            }
        }
        static void Ex7()
        {
            // Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar

            Console.WriteLine("Introduceti numarul ");
            int numar = int.Parse(Console.ReadLine());

            if (numar % 2 == 0)
            {
                Console.WriteLine("par");

            }
            else
            {
                Console.WriteLine("impar");
            }
        }
        static void Ex8()
        {
            // Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica daca x este divizibil cu y.

            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            if (x % y == 0)
            {
                Console.WriteLine("Divizibile");
            }
            else
            {
                Console.WriteLine("indivizibile");

            }
        }
        static void Ex9()
        {
            // aici vom pune rezolvarea pentru exercitiu 9
        }
        static void Ex10()
        {
            //  Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.
            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            int sumaCifrelor = x / 10 + x % 10;

            Console.WriteLine("suma cifrelor este " + sumaCifrelor);
        }
    }
}
