using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyber_School
{
    public abstract class Validation
    {
        protected string StringCheck(string msg)
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                string input;

                try
                {
                    input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("WARNING-!:you cant enter empty string!");
                        continue;
                    }
                    else if (input.Any(char.IsDigit))
                    {
                        Console.WriteLine("WARNING-!:Name cant have numbers in it !");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return input;
            }
        }

        protected int IntIDCheck(string msg)

        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                int input;

                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input.ToString().Length != 9)
                    {
                        Console.WriteLine("WARNING-!:ID Must Be Length Of 9!");
                        continue;
                    }
                    else if (input < 0)
                    {
                        System.Console.WriteLine("WARNING-!:Can not Be Negative ");
                        continue;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("WARNING-!:ID need to be is a numbers format\n-ex:123456789-");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return input;
            }
        }
        protected int IntCheck(string msg)
        
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                int input;

                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input < 1)
                    {
                        System.Console.WriteLine("WARNING-!:Point Can not Be Negative or 0");
                        continue;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("WARNING-!:need to be in a numbers format\n-ex:12-");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return input;
            }
        }

        protected double DoubleCheck(string msg)
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                double input;

                try
                {
                    input = double.Parse(Console.ReadLine());
                    if (input < 1)
                    {
                        System.Console.WriteLine("WARNING-!:Can not Be Negative or 0 ");
                        continue;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("WARNING-!:need to be in a Double format\n-ex:12.2-");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return input;
            }
        }
        protected DateTime DateTimeCheck(string msg)
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                DateTime input;

                try
                {
                    input = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                    if (!checkAge(input))
                    {
                        Console.WriteLine("--You Need To Be Over 16 To Register!---");
                        continue;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:Invalid date");
                    continue;
                }
                return input;
            }
        }

        protected bool checkAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }
            return age >= 16;
        }
        protected T EnumCheck<T>(string msg) where T : Enum
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                int input;
                try
                {
                    input = int.Parse(Console.ReadLine());

                    if (!Enum.IsDefined(typeof(T), input))
                    {
                        Console.WriteLine("WARNING-!:Option Not In Range!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("WARNING-!:need to be in a numbers format\n-ex:1-");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return (T)Enum.ToObject(typeof(T), input);
            }
        }
    }
}