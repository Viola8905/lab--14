using System;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random(DateTime.Now.Millisecond);
            double[] figures = new double[n];
           

            double riv=0;
            double rivst=0;
            double pr=0;

            for (int i = 0; i < figures.Length; i++)
            {
                int num = random.Next(1, 3);
                if (num == 1)
                {
                    double a = random.Next(1, 10);
                    Rivnostor f = new Rivnostor(a);
                    TTriangle i1 = (TTriangle)f;
                    

                    figures[i] = i1.Square();
                    


                    Console.Write(figures[i]);

                    rivst = rivst + figures[i];
                }
                else if (num == 2)
                {
                    double a = random.Next(1, 10);
                    double b = random.Next(1, 10);
                    Rivnobed r = new Rivnobed(a, b);
                    TTriangle i2 = (TTriangle)r;

                    figures[i] = i2.Perimeter();
                    Console.Write(figures[i]);
                    riv += figures[i];
                }
                else
                {
                    double a = random.Next(1, 10);
                    double b = random.Next(1, 10);

                    Pryamokut p = new Pryamokut(a, b);
                    TTriangle i3 = (TTriangle)p;

                    figures[i] = i3.Square();
                    Console.Write(figures[i]);
                    pr += figures[i];
                }
            }
            Console.WriteLine("Suma of P RivB={0}", riv);
            Console.WriteLine("Suma of S RivSt={0}", rivst);
            Console.WriteLine("Suma of S Pryam={0}", pr);

        }
    }
}
