using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRUDI2.Entities
{
        public class OpetarionBasic
        {

            public static void Sum(ref int num1, ref int num2)
            {

                num1 = num1 + num2;
                Console.WriteLine("SUM:" + num1);

            }

            public static void Subtraction(ref int num1, ref int num2)
            {

                num1 = num1 - num2;
                Console.WriteLine("Subtraction:" + num1);

            }

            public static void Divide(ref int num1, ref int num2)
            {

                num1 = num1 / num2;
                Console.WriteLine("Divide:" + num1);

            }

            public static void Miltiply(ref int num1, ref int num2)
            {

                num1 = num1 * num2;
                Console.WriteLine("Multipli:" + num1);

            }
        }

    public abstract class TriangleBase
    {
        public abstract decimal Perimeter(int FirstSide, int SecondSide, int ThirdSide);

        public double CalculateAreaWithHypotenuse(int lado, int hipotenusa)
        {
            double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
            return lado * ladob / 2;
        }
    }

    public class Scalenno : TriangleBase
    {
        public override decimal Perimeter(int FirstSide, int SecondSide, int ThirdSide)
        {
            int Result = FirstSide + SecondSide + ThirdSide;
            return Result;
            
        }
    }
}

