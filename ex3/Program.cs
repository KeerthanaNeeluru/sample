using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode;
            string lang,choice;

            do {
                Console.WriteLine("Enter Country code");
                cCode = Console.ReadLine().ToUpper();

                switch (cCode)
                {
                    case "UK":
                    case "US":
                        {
                            lang = "English";
                            break;
                        }
                    case "AF":
                        {
                            lang = "Dari,Pashto";
                            break;
                        }
                    case "IND":
                        {
                            lang = "Hindi,english,tamil";
                            break;
                        }
                    case "UAE":
                    case "OM":
                    case "KSA":
                    case "EGYPT":
                        {
                            lang = "Arabic";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"sorry !!! your country {cCode} is not in our database");
                            lang = "Not Found !!!!!!!";
                            break;
                        }

                }
                Console.WriteLine("Country Code : " + cCode + "\nLanguage(s) " + lang);
                Console.WriteLine("If you want to continue press y else press n");
                choice = Console.ReadLine().ToUpper();
            } while (choice=="Y");
                Console.ReadKey();
        }
    }
}
