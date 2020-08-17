using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruteforce
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] charlist = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] alfabeto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


            string password = "999999";

            //Console.WriteLine("Inserisci una password di 5 caratteri alfanumerici key sensitive");
            //password = Console.ReadLine();


            string char1, char2, char3, char4, char5, char6, result = "";
            bool flag = false;
            int i = 1;
            foreach (string x in charlist)
            {
                Console.WriteLine(result + "   -   " + i);
                if (flag == true)
                    break;
                char1 = x;

                foreach (string y in charlist)
                {
                    char2 = y;
                    if (flag == true)
                        break;

                    foreach (string z in charlist)
                    {
                        char3 = z;
                        if (flag == true)
                            break;

                        foreach (string j in charlist)
                        {
                            char4 = j;
                            if (flag == true)
                                break;

                            foreach (string w in charlist)
                            {
                                char5 = w;
                                if (flag == true)
                                    break;

                                foreach (string k in charlist)
                                {
                                    char6 = k;
                                    result = char1 + char2 + char3 + char4 + char5 + char6;
                                    //Console.WriteLine(result+"   -   "+i);
                                    i++;

                                    if (result == password)
                                    {
                                        flag = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(result + "   -   " + i);
            Console.ReadKey();
        }
    }
}

