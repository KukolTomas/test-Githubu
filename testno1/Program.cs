using System;

namespace testno1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //if (!TryParse("x", out x))
            //    x = -1;
            //Console.WriteLine(x);
            DateTime dt = new DateTime(2000,2,3);
            DateTime dt2;
            string datum = "2000-2-3";
            if(DateTime.TryParse(datum, out dt2))
            {
                dt2 = dt2.AddDays(5);
                Console.WriteLine(dt2);
            }
            else
            {
                Console.WriteLine("Není datetime");
            }
            Console.WriteLine(new Program());

            Console.ReadLine();
            
        }

        public override string ToString()
        {
            var s = base.ToString();
            return string.Format("Toto je muj program {0}.", s);
        }

        static bool TryParse(string x, int y)
        {
            try
            {
                y = int.Parse(x);
                return true;
            }
            catch (FormatException)
            {
                // y = int.MinValue;
                return false;
            }

        }
    }
}
