using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringList sl = new StringList();

            double d = "hello";

            try
            {
                Function();
            }catch (MyNewException mnex)

            {
                Console.WriteLine("mine");
            }
            
            catch(NullReferenceException nex)
            {
                Console.WriteLine(nex.Message);
                throw;
            }
            catch(IndexOutOfRangeException iex)
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;

            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.ReadKey();


        }

        static void Function2()
        {
            try
            {

            }
            finally 
            {
                
            }

        }


        static void Function()
        {
            string s = Console.ReadLine();

            bool exception = false;
            try
            {
                if (s == "test")
                {
                    return;
                }
                
            }
            catch (Exception ex)
            {
                exception = true;
                throw;
            }
            finally
            {
                Console.WriteLine("inside the finally");                
            }

            if(!exception)
            {

            }



            if (string.IsNullOrWhiteSpace(s))
            {
                Exception e = new MyNewException();
                throw e;

            }


            Console.WriteLine(s);

        }
    }

    class StringList : List<string>{
        public void Something()
        {

        }

    }


    class MyNewException : Exception
    {


        public MyNewException() : this("empty message") 
        {

        }

        public MyNewException(string msg) : base(msg)
        {

        }

    }
}
