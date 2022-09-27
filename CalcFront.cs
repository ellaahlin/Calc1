﻿using System;
using static System.Console;

namespace Calc
{
    public class CalcFront
    {
        public void Run()
        {
            Welcome();
            Menu();
        }

        private void Welcome()
        {
            WriteLine("============================");
            WriteLine("Välkommen till miniräknaren!");
            WriteLine("============================");
        }

        private void Menu()
        {
            WriteLine("1. Använd miniräknaren\n2. Se historik");
            int val = Convert.ToInt32(ReadLine());

            switch (val)
            {
                case 1:
                    Clear();
                    Write("Skriv in en beräkning: ");
                    string beräkning = ReadLine();
                    if (beräkning.Contains("+"))
                    {
                        int plus = beräkning.IndexOf("+");
                        string temp1 = beräkning[..plus];
                        string temp2 = beräkning[(plus + 1)..];
                        int tal1 = Convert.ToInt32(temp1);
                        int tal2 = Convert.ToInt32(temp2);
                        int addition = tal1 + tal2;
                        WriteLine($"{tal1} + {tal2} = {addition}");
                        ReadLine();
                    }
                    else if (beräkning.Contains("-"))
                    {
                        int minus = beräkning.IndexOf("-");
                        string temp1 = beräkning[..minus];
                        string temp2 = beräkning[(minus + 1)..];
                        int tal1 = Convert.ToInt32(temp1);
                        int tal2 = Convert.ToInt32(temp2);
                        int subtraktion = tal1 - tal2;
                        WriteLine($"{tal1} - {tal2} = {subtraktion}");
                        ReadLine();
                    }
                    else if (beräkning.Contains("*"))
                    {
                        int mult1 = beräkning.IndexOf("*");
                        string temp1 = beräkning[..mult1];
                        string temp2 = beräkning[(mult1 + 1)..];
                        int tal1 = Convert.ToInt32(temp1);
                        int tal2 = Convert.ToInt32(temp2);
                        int multiplikation = (tal1 * tal2);
                        WriteLine($"{tal1} * {tal2} = {multiplikation}");
                        ReadLine();
                    }
                    else if (beräkning.Contains("x"))
                    {
                        int mult2 = beräkning.IndexOf("x");
                        string temp1 = beräkning[..mult2];
                        string temp2 = beräkning[(mult2 + 1)..];
                        int tal1 = Convert.ToInt32(temp1);
                        int tal2 = Convert.ToInt32(temp2);
                        int multiplikation = (tal1 * tal2);
                        WriteLine($"{tal1} x {tal2} = {multiplikation}");
                        ReadLine();
                    }
                    else if (beräkning.Contains("/"))
                    {
                        int div = beräkning.IndexOf("/");
                        string temp1 = beräkning[..div];
                        string temp2 = beräkning[(div + 1)..];
                        int tal1 = Convert.ToInt32(temp1);
                        int tal2 = Convert.ToInt32(temp2);
                        int division = (tal1 / tal2);
                        WriteLine($"{tal1} / {tal2} = {division}");
                        WriteLine("Vill du utföra en ny beräkning? (j/n): ");
                        
                        ReadLine();
                    }
                    break;

                case 2:
                    Clear();
                    break;

                default:
                    Clear();
                    Run();
                    break;
            }
        }

        private void History()
        {

        }


    }
}
