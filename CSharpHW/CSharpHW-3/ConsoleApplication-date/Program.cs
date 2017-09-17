using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApplication_date
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var date = GetDateOfBirth();
            var years = (int)Math.Floor((DateTime.Now - date).TotalDays / 365);
            
            Console.WriteLine("Your age is: {0}", years);
            
            Zodiac(date);
        }

        private static DateTime GetDateOfBirth()
        {
            Console.WriteLine("Input your date of birth (DD/MM/YYYY)");
            var birthDay = Console.ReadLine();
            
            string pattern = "[0-9]{2}/[0-9]{2}/[0-9]{2}";            
            Regex rx = new Regex(pattern);
            if (!rx.IsMatch(birthDay))
            {
                GetDateOfBirth();
            }
            
            var date = Convert.ToDateTime(birthDay);
            return date;
        }

        private static void Zodiac(DateTime date)
        {
            switch (date.Month)
                {
                    case 1:
                        Console.WriteLine(date.Day <= 20
                            ? "Your zodiac sign is Capricorn"
                            : "Your zodiac sign is Aquarius");
                        break;
                        
                    case 2:   
                        Console.WriteLine(date.Day <= 19 
                            ? "Your zodiac sign is Aquarius" 
                            : "Your zodiac sign is Pisces");
                        break;
                        
                    case 3:
                        Console.WriteLine(date.Day <= 20 
                            ? "Your zodiac sign is Pisces" 
                            : "Your zodiac sign is Aries");
                        break;
                        
                    case 4:
                        Console.WriteLine(date.Day <= 20 
                            ? "Your zodiac sign is Aries" 
                            : "Your zodiac sign is Taurus");
                        break;
                        
                    case 5:
                        Console.WriteLine(date.Day <= 21 
                            ? "Your zodiac sign is Taurus" 
                            : "Your zodiac sign is Gemini");
                        break;
                        
                    case 6:
                        Console.WriteLine(date.Day <= 22 
                            ? "Your zodiac sign is Gemini" 
                            : "Your zodiac sign is Cancer");
                        break;
                        
                    case 7:
                        Console.WriteLine(date.Day <= 22 
                            ? "Your zodiac sign is Cancer" 
                            : "Your zodiac sign is Leo");
                        break;
                        
                    case 8:
                        Console.WriteLine(date.Day <= 23 
                            ? "Your zodiac sign is Leo" 
                            : "Your zodiac sign is Virgo");
                        break;
                        
                    case 9:
                        Console.WriteLine(date.Day <= 23 
                            ? "Your zodiac sign is Virgo" 
                            : "Your zodiac sign is Libra");
                        break;
                        
                    case 10:
                        Console.WriteLine(date.Day <= 23 
                            ? "Your zodiac sign is Libra" 
                            : "Your zodiac sign is Scorpio");
                        break;
                        
                    case 11:
                        Console.WriteLine(date.Day <= 22
                            ? "Your zodiac sign is Scorpio"
                            : "Your zodiac sign is Sagittarius");
                        break;
                        
                    case 12:
                        Console.WriteLine(date.Day <= 21
                            ? "Your zodiac sign is Sagittarius"
                            : "Your zodiac sign is Capricorn");
                        break;
                        
                    default:
                        Console.WriteLine("Your zodiac sign was not found! Please try again!");
                        break;
                }
        }
    }
}