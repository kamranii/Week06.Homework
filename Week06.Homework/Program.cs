using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Week06.Homework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Task1
            ////Create threads
            //Thread firstThread = new Thread(Method1);
            //Thread secondThread = new Thread(Method2);
            ////Start threads
            //firstThread.Start();
            //secondThread.Start();

            //Console.WriteLine($"{firstThread.Name} is alive: {firstThread.IsAlive}");
            //Console.WriteLine($"{secondThread.Name} is alive: {secondThread.IsAlive}");
            ////Method1
            //static void Method1()
            //{
            //    for (int i = 1; i <= 20; i++)
            //    {
            //        Console.WriteLine($"Method1 - {i}");
            //        Thread.Sleep(100);                }
            //}
            ////Method2
            //static void Method2()
            //{
            //    for (int i = 1; i <= 20; i++)
            //    {
            //        Console.WriteLine($"Method2 - {i}");
            //        Thread.Sleep(100);
            //    }
            //}
            #endregion
            #region Task2
            //Store the url
            const string path = "https://catfact.ninja/fact";
            //HTTPClient to send request
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(path);
            Console.WriteLine(response);
            CatFact newFact = new CatFact();
            newFact = JsonConvert.DeserializeObject<CatFact>(response);
            Console.WriteLine($"New fact is: {newFact.fact}");

            //Resources:

            
            #endregion
            #region Task3
            ////Get the string
            //Console.Write("Please input an alphanumeric string: ");
            //string input = Console.ReadLine();
            ////Output the result
            //Console.WriteLine($"Sum of the digits in the {input} is: {SumDigitsInString(input)}");
            ////Method to calculate sum of the digits
            //static int SumDigitsInString(string s)
            //{
            //    int sum = 0;
            //    //Loop to check each character
            //    for(int i = 0; i < s.Length; i++)
            //    {
            //        if (Char.IsDigit(s, i))
            //        {
            //            sum += (int) Char.GetNumericValue(s[i]);
            //        }
            //    }
            //    return sum;
            //}
            #endregion
            #region Task4
            ////Create a list of integers
            //List<int> integers = new List<int>();
            ////Get the list length
            //Console.Write("Input number of integers in the list: ");
            //byte listLength = byte.Parse(Console.ReadLine());
            ////Get the list elements
            //for (int i=0; i < listLength; i++)
            //{
            //    Console.Write($"Input element {i + 1} of the list: ");
            //    if(int.TryParse(Console.ReadLine(), out int element))
            //    {
            //        integers.Add(element);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input!!!");
            //    }
            //}
            ////Sort the list
            //integers.Sort();
            ////Reverse the list
            //integers.Reverse();
            ////Querry
            //var topFive = integers.Take(5);
            ////Output the top 5 integers
            //foreach (int i in topFive)
            //{
            //    Console.Write(i + " ");
            //}

            //Note:
            //Müəllim bütün hissəni querry ilə eliyə bilmədim.
            //Ənənəvi array methodlari ilə köməkli elədim ancaq
            #endregion
            #region Task5
            ////Get a sentence
            //Console.Write("Input a sentence: ");
            //string sentence = Console.ReadLine();
            ////Seperate each word
            //var words = sentence.Split(' ');
            ////Store all uppercase words
            //var upperCase = words.Where(x => x == x.ToUpper());
            ////Output result
            //foreach(var item in upperCase)
            //{
            //    Console.WriteLine(item);
            //}

            //Resources:
            //https://stackoverflow.com/questions/5270180/how-to-check-filter-uppercase-words-alone-from-a-string-using-c
            //https://zetcode.com/csharp/splitstring/
            #endregion
            #region Task6
            ////Get a year
            //Console.Write("Input a year: ");
            //int inputYear = int.Parse(Console.ReadLine());
            ////Output the result
            //if(IfYearIsLeap(inputYear))
            //{
            //    Console.WriteLine($"The year {inputYear} is leap");
            //}
            //else
            //    Console.WriteLine($"The year {inputYear} is not leap");
            ////Check "leapness"
            //static bool IfYearIsLeap(int year)
            //{
            //    if (DateTime.IsLeapYear(year))
            //    {
            //        return true;
            //    }
            //    else
            //        return false;
            //}

            //Resources
            //https://stackoverflow.com/questions/10495802/how-to-get-the-total-number-of-days-in-a-year-from-the-given-date
            #endregion
        }

    }
    public class CatFact
    {
        public string fact;
        public int length;
    }
}

