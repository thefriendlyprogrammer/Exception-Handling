using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class exphandler
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Exception handle with try catch and finally keyword: ");
            }

            Console.WriteLine("Rest of the code");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling
            try
            {
                Test1();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Exception handle with try, catch, finallyand throw and throw ex keyword: ");
            }

            Console.ReadLine();
        }

        static void Test1()
        {
            try
            {
                Test2();
            }
            catch (Exception)
            {

                throw;
            }

        }

        static void Test2()
        {
            try
            {
                Test3();
            }
            catch (Exception ab)
            {

                throw ab;
            }

        }

        static void Test3()
        {
            try
            {
                Test4();
            }
            catch (Exception)
            {

                throw;
            }

        }

        static void Test4()
        {
            try
            {
                Test5();
            }
            catch (Exception)
            {

                throw;
            }

        }

        static void Test5()
        {
            Console.WriteLine("Enter First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());

            try
            {
                int c = a / b;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
