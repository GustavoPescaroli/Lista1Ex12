using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double p3;
            double p4;
            double p5;
            double Total;
            double troco;
            double x;

            Console.WriteLine("valor p1");
            p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("valor p2");

            p2 = double.Parse(Console.ReadLine());
            Console.WriteLine("valor p3");
            p3 = double.Parse(Console.ReadLine());
            Console.WriteLine("valor p4");
            p4 = double.Parse(Console.ReadLine());
            Console.WriteLine("valor p5");
            p5 = double.Parse(Console.ReadLine());

            Total = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine("valor total da compra {0}", Total);

            Console.WriteLine("dinheiro");
            x = double.Parse(Console.ReadLine());
            troco = +Total - x;
            Console.WriteLine("valor do troco {0}", troco);
           


        }   }   }
