using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompArt_FromSimplicityToComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
Please select the drawing type:
1. Serpinski
2. Koch
");
            var x = Console.ReadKey().KeyChar;
            switch (x)
            {
                case '1':
                    Sierpinsky(); break;
                case '2':
                    Koch(4); break;

            }
        }

        static void Koch(int v)
        {
            throw new NotImplementedException();
        }

        protected static Random rnd = new Random();
        public static T Pick<T>(T[] Choices)
        {
            var n = rnd.Next(0, Choices.Length);
            return Choices[n];
        }


        static void Sierpinsky()
        {
            var Vertices = new Tuple<int, int>[] { new Tuple<int, int>(0, 600), new Tuple<int, int>(300, 0), new Tuple<int, int>(600, 600) };
            var p = new Tuple<int, int>(300, 300);
            GraphicsWindow.Show();
            for (int i = 0; i < 100000; i++)
            {
                GraphicsWindow.SetPixel(p.Item1, p.Item2, "Black");
                var v = Pick(Vertices);
                p = new Tuple<int,int>((p.Item1 + v.Item1) / 2, (p.Item2 + v.Item2) / 2);
            }             
        }
    }
}
