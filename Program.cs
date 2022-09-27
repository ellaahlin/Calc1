using System;
using static System.Console;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcFront myCalc = new CalcFront();
            myCalc.Run();
            List<string> resultat = new List<string>();
        }
    }
}
