using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _14_Exception
{
    internal class Program
    {
        /*// test filters Exception
        static int DivisionNumber(int n1, int n2) {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException de)
            {
                throw new Exception("Filter check Exception",de);
            }
            return result;
        }*/
        // test up Exception
        /*static int DivisionNumber(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException de)
            {
                throw;
            }
            return result;
        }*/
        // details exception
        class MyClass
        {
            public void BadMethod()
            {
                Exception exception = new Exception("My Exception message");
                exception.HelpLink = "https://stackoverflow.com";
                exception.Data.Add("Exception", "Test exception");
                exception.Data.Add("Time invoke", DateTime.Now);
                exception.Data.Add("user name", "Dasha");
                throw exception;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                MyClass instance = new MyClass();
                instance.BadMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Member name  :: {ex.TargetSite}");
                Console.WriteLine($"Member class :: {ex.TargetSite.DeclaringType}");
                Console.WriteLine($"Member type  :: {ex.TargetSite.MemberType}");
                Console.WriteLine($"Method name  :: {ex.TargetSite.Name}");
                Console.WriteLine($"Message      :: {ex.Message}");
                Console.WriteLine($"Source       :: {ex.Source}");
                Console.WriteLine($"HelpLink     :: {ex.HelpLink}");
                Console.WriteLine($"Stack        :: {ex.StackTrace}");
                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine($"{item.Key} -- {item.Value}");
                }
            }
            

            // test filters Exception
            /*Console.WriteLine("Enter two numbers");
            int number1, number2, result;
            try
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                result = DivisionNumber(number1, number2);
                Console.WriteLine($"Result division numbers :: {result}");
            }
            catch (Exception e)when(e.InnerException != null)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("-------");
                Console.WriteLine(ex.Message);
            }*/
            // test up Exception
            /*Console.WriteLine("Enter two numbers");
            int number1, number2, result;
            try
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                result = DivisionNumber(number1, number2);
                Console.WriteLine($"Result division numbers :: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("-------");
                Console.WriteLine(ex.Message);
            }*/
            /*Console.WriteLine("Test Product");
            Product product = new Product();
            try
            {
                product.Name = "Bread";
                Console.WriteLine(product.Name);
                product.DateIn = new DateTime(2024, 12, 20);
            }
            catch(BadProductException ex)
            {
                Console.WriteLine("Message error  :: " + ex.Message);
                Console.WriteLine("Bad vale(date) :: " + ex.ErrorDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message :: {ex.Message}");
                if(ex.Data.Contains("Value"))
                {
                    Console.WriteLine($"Value     :: {ex.Data["Value"]}");
                    Console.WriteLine($"TimeStamp :: {ex.Data["TimeStamp"]}");
                }
                Console.WriteLine($"TargetSite : {ex.TargetSite}");
                foreach (var key in ex.Data.Keys)
                {
                    Console.WriteLine($"{key}  ----- {ex.Data[key]}");
                }
            }
            product.InputName();
            Console.WriteLine(product.Name);*/
            /*try
            {
                Console.WriteLine("Enter two numbers ");
                int a, b;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            *//*catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error!!! Divide by zero");
            }*//*
            catch (FormatException ex){
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Continue ... ");
            Console.ReadKey();*/
        }
    }
}
