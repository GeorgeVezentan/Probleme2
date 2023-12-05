using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Probleme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P01();
            //P02();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            P17();
        }

        private static void P17()
        {
            Console.Write("Introduceti secventa de 0 si 1 (delimitate de spatiu): ");
            string input = Console.ReadLine();

            int nivelMaxim = DeterminaNivelMaxim(input);

            if (nivelMaxim != -1)
            {
                Console.WriteLine($"Secventa este corecta și nivelul maxim de incuibare este: {nivelMaxim}");
            }
            else
            {
                Console.WriteLine("Secventa NU este corecta.");
            }

            Console.ReadLine(); 
        }

        static int DeterminaNivelMaxim(string input)
        {
            int nivel = 0;
            int nivelMaxim = 0;

            foreach (char caracter in input)
            {
                if (caracter == '0')
                {
                    nivel++;
                    nivelMaxim = Math.Max(nivelMaxim, nivel);
                }
                else if (caracter == '1')
                {
                    nivel--;
                    if (nivel < 0)
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
            return nivel == 0 ? nivelMaxim : -1;
        }

        private static void P16()
        {
            Console.Write("Introduceti secventa de numere (delimitate de spatiu): ");
            string input = Console.ReadLine();

            if (IsBitonicaRotita(input))
            {
                Console.WriteLine("Secventa este o secventa bitonica rotita.");
            }
            else
            {
                Console.WriteLine("Secventa NU este o secventa bitonica rotita.");
            }

            Console.ReadLine(); 
        }

        static bool IsBitonicaRotita(string input)
        {
            input = input.Trim(); 
            if (input.Length < 3)
            {
                return false;
            }

            bool aCrescator = true;
            bool aDescrescator = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                {
                    if (aDescrescator)
                    {
                        return false;
                    }
                }
                else if (input[i] > input[i + 1])
                {
                    aDescrescator = true;
                    aCrescator = false;
                }
            }
            return aCrescator || aDescrescator;
        }

        private static void P15()
        {
            Console.Write("Introduceti secventa de numere (delimitate de spatiu): ");
            string input = Console.ReadLine();

            if (IsBitonica(input))
            {
                Console.WriteLine("Secventa este bitonica.");
            }
            else
            {
                Console.WriteLine("Secventa NU este bitonica.");
            }

            Console.ReadLine();
        }

        static bool IsBitonica(string input)
        {
            input = input.Trim(); 
            if (input.Length < 3)
            {
                return false;
            }

            bool aCrescator = true;
            bool aDescrescator = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                {

                    if (aDescrescator)
                    {
                        return false;
                    }
                }
                else if (input[i] > input[i + 1])
                {
                    aDescrescator = true;
                    aCrescator = false;
                }
            }
            return aCrescator && aDescrescator;
        }

        private static void P14()
        {
            Console.Write("Introduceti secventa de numere (delimitate de spatiu): ");
            string input = Console.ReadLine();

            if (IsMonotonaRotita(input))
            {
                Console.WriteLine("Secventa este o secventa monotona rotita.");
            }
            else
            {
                Console.WriteLine("Secventa NU este o secventa monotona rotita.");
            }

            Console.ReadLine(); 
        }

        static bool IsMonotonaRotita(string input)
        {
            input = input.Trim(); 

            bool isMonotona = true;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    isMonotona = false;
                    break;
                }
            }

            return isMonotona || IsRotitaMonotona(input);
        }

        static bool IsRotitaMonotona(string input)
        {
            char primulCaracter = input[0];
            string secventaRotita = input.Substring(1) + primulCaracter;

            bool isMonotonaRotita = true;
            for (int i = 0; i < secventaRotita.Length - 1; i++)
            {
                if (secventaRotita[i] > secventaRotita[i + 1])
                {
                    isMonotonaRotita = false;
                    break;
                }
            }

            return isMonotonaRotita;

        }

        private static void P13()
        {
            Console.Write("Introduceti secventa de numere (delimitate de spatiu): ");
            string input = Console.ReadLine();

            if (IsCrescatoareRotita(input))
            {
                Console.WriteLine("Secventa este o secventa crescatoare rotita.");
            }
            else
            {
                Console.WriteLine("Secventa NU este o secventa crescatoare rotita.");
            }

            Console.ReadLine(); 
        }

        static bool IsCrescatoareRotita(string input)
        {
            input = input.Trim(); 
            bool isCrescatoare = true;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    isCrescatoare = false;
                    break;
                }
            }
            return isCrescatoare || IsRotitaCrescatoare(input);
        }

        static bool IsRotitaCrescatoare(string input)
        {
            char primulCaracter = input[0];
            string secventaRotita = input.Substring(1) + primulCaracter;

            bool isCrescatoareRotita = true;
            for (int i = 0; i < secventaRotita.Length - 1; i++)
            {
                if (secventaRotita[i] > secventaRotita[i + 1])
                {
                    isCrescatoareRotita = false;
                    break;
                }
            }

            return isCrescatoareRotita;
        }

        private static void P12()
        {
            Console.Write("Introduceti secventa de numere (delimitate de spatiu): ");
            string input = Console.ReadLine();

            int numarGrupuri = 0;
            bool inGrup = false;

            foreach (char caracter in input)
            {
                if (caracter == '0')
                {
                    if (!inGrup)
                    {
                        inGrup = true;
                        numarGrupuri++;
                    }
                }
                else
                {
                    inGrup = false;
                }
            }

            Console.WriteLine($"Numarul de grupuri este: {numarGrupuri}");
        }

        private static void P11()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sumaInverselor = 0;

            Console.WriteLine($"Introduceti cele {n} numere:");
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                double numar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ati introdus: {numar}");
                sumaInverselor = 1 / numar;
                suma = (1 / numar) + (1 / numar);

            }
            Console.WriteLine($"Suma inverselor este: {suma}");
        }
        private static void P10()
        {
            Console.WriteLine("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int lungimeMaxima = 1;
            int lungimeCurenta = 1;
            int numarPrecedent = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent == numarPrecedent)
                    lungimeCurenta++;
                else
                    lungimeCurenta = 1;

                if (lungimeCurenta > lungimeMaxima)
                    lungimeMaxima = lungimeCurenta;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale este: {lungimeMaxima}");
        }

        private static void P9()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            int[] secventa = new int[n];

            // Citirea elementelor secventei
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }

            // Verificarea monotoniilor
            bool esteMonotonaCrescatoare = true;
            bool esteMonotonaDescrescatoare = true;

            for (int i = 1; i < n; i++)
            {
                if (secventa[i] > secventa[i - 1])
                    esteMonotonaDescrescatoare = false;
                else if (secventa[i] < secventa[i - 1])
                    esteMonotonaCrescatoare = false;
            }
            // Afisarea rezultatului
            if (esteMonotonaCrescatoare)
                Console.WriteLine("Secventa este monoton crescatoare.");
            else if (esteMonotonaDescrescatoare)
                Console.WriteLine("Secventa este monoton descrescatoare.");
            else
                Console.WriteLine("Secventa nu este monotonă.");
        }

        private static void P8()
        {
            Console.Write("Introduceti valoarea lui n pentru a determina al n-lea numar din sirul lui Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("n trebuie sa fie un numar pozitiv.");
                return;
            }

            int fibN = CalculFibonacci(n);

            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {fibN}");
        }

        static int CalculFibonacci(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int fibNMinus1 = 1;
                int fibNMinus2 = 0;
                int fibN = 0;

                for (int i = 3; i <= n; i++)
                {
                    fibN = fibNMinus1 + fibNMinus2;
                    fibNMinus2 = fibNMinus1;
                    fibNMinus1 = fibN;
                }

                return fibN;
            }
        }

        private static void P7()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int lungimeSecventa = Convert.ToInt32(Console.ReadLine());

            if (lungimeSecventa <= 0)
            {
                Console.WriteLine("Lungimea secventei trebuie sa fie un numar pozitiv.");
                return;
            }
            Console.WriteLine("Introduceti elementele secventei:");

            int valoareMinima = int.MaxValue;
            int valoareMaxima = int.MinValue; 
            for (int i = 0; i < lungimeSecventa; i++)
            {
                Console.Write($"Elementul de pe pozitia {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                if (element < valoareMinima)
                    valoareMinima = element;
                if (element > valoareMaxima)
                    valoareMaxima = element;
            }

            Console.WriteLine($"Valoarea minima din secventa este: {valoareMinima}");
            Console.WriteLine($"Valoarea maxima din secventa este: {valoareMaxima}");



        }

        private static void P6()
        {
            Console.WriteLine("Introduceti o secventa de numere");
            int lungimeSecventa = Convert.ToInt32(Console.ReadLine());

            bool esteCrescatoare = VerificaOrdineaCrescatoare(lungimeSecventa);

            if (esteCrescatoare)
                Console.WriteLine("Secventa este in ordine crescatoare");
            else
                Console.WriteLine("Secventa nu este in ordine crescatoare");
        }

        private static bool VerificaOrdineaCrescatoare(int lungimeSecventa)
        {
            if (lungimeSecventa <= 1)
                return true;
            int elementAnterior = int.MinValue;

            for (int i = 0; i < lungimeSecventa; i++)
            {
                Console.Write($"Introduceti elementul de pe pozitia {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                if (element < elementAnterior)
                  return false;
                elementAnterior = element;
            }
            return true;
        }

        private static void P5()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int lungimeSecventa = Convert.ToInt32(Console.ReadLine());

            int numarElementeEgaleCuPozitia = NumaraElementeEgaleCuPozitia(lungimeSecventa);

            Console.WriteLine($"Numarul de elemente egale cu pozitia in secventa este: {numarElementeEgaleCuPozitia}");

        }

        private static int NumaraElementeEgaleCuPozitia(int lungimeSecventa)
        {
            int numarElementeEgale = 0;

            for (int i = 0; i < lungimeSecventa; i++)
            {
                Console.Write($"Introduceti elementul de pe pozitia {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());

                if (element == i)
                    numarElementeEgale++;
            }
            return numarElementeEgale;
        }

        private static void P4()
        {
            Console.WriteLine("Introduceti lungimea secventei: ");
            int lungimeSecventa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti numarul cautat: ");
            int numarCautat = Convert.ToInt32(Console.ReadLine());

            int pozitie = CautareNumar(lungimeSecventa, numarCautat);
            if (pozitie != -1)
                Console.WriteLine($"Numarul {numarCautat} se afla pe pozitia {pozitie} in secventa.");
            else 
                Console.WriteLine($"Numarul {numarCautat} nu se afla in secventa.");
        }

        private static int CautareNumar(int lungimeSecventa, int numarCautat)
        {
            for (int i = 0; i < lungimeSecventa; i++)
            {
                Console.WriteLine($"Introduceti elementul de pe pozitia {i}");
                int element = Convert.ToInt32(Console.ReadLine());
                if (element == numarCautat)
                    return i;
            }
            return -1;
        }

        private static void P3()
        {
            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;
            int produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n}: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n}: {produs}");
        }

        private static void P02()
        {
            Console.WriteLine("Introduceti numarul de elemente: ");
            int numar = int.Parse(Console.ReadLine());

            int negativCount = 0;
            int zeroCount = 0; 
            int pozitivCount = 0;

            for(int i = 0 ; i < numar ; i++)
            {
                Console.WriteLine($"Introduceti elementul #{ i + 1 }:");
                int num = int.Parse(Console.ReadLine());

                if ( num < 0 )
                    negativCount++;
                else if ( num == 0 )
                    zeroCount++;
                else
                    pozitivCount++;
            }
            Console.WriteLine($"Numerele negative sunt: {negativCount}");
            Console.WriteLine($"Numerele pozitive sunt: {pozitivCount}");
            Console.WriteLine($"Numerele egale cu 0 sunt: {zeroCount}");
        }

        private static void P01()
        {
            Console.WriteLine("Introduceti lungimea secventei");
            int n = int.Parse(Console.ReadLine());
            int Pare = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());
                if (Par(numar))
                Pare++;
            }
            Console.WriteLine($"Numerele pare sunt: {Pare}");
        }

        private static bool Par(int numar)
        {
            return numar % 2 == 0;
        }
    }
}
