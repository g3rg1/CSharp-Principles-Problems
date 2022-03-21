using System;

namespace Number_Exeption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                var result = Math.Sqrt(n);
                if (double.IsNaN(result))
                {
                    throw new NotFiniteNumberException(result);
                }

                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number.");

            }
            catch(NotFiniteNumberException)
            {
                Console.WriteLine("Invalid Number.");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
