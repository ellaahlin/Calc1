using System;
using static System.Console;

namespace Calc
{
    public class CalcFront
    {
        List<string> beräkningar = new List<string>();

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
            string retry = "n";

            do
            {
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
                            string resultat = $"{tal1} + {tal2} = {addition}";
                            beräkningar.Add(resultat);
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
                            string resultat = $"{tal1} - {tal2} = {subtraktion}";
                            beräkningar.Add(resultat);
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
                            string resultat = $"{tal1} * {tal2} = {multiplikation}";
                            beräkningar.Add(resultat);
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
                            string resultat = $"{tal1} x {tal2} = {multiplikation}";
                            beräkningar.Add(resultat);
                        }
                        else if (beräkning.Contains("/"))
                        {
                            try
                            {

                                int div = beräkning.IndexOf("/");
                                string temp1 = beräkning[..div];
                                string temp2 = beräkning[(div + 1)..];
                                int tal1 = Convert.ToInt32(temp1);
                                int tal2 = Convert.ToInt32(temp2);
                                int division = (tal1 / tal2);
                                WriteLine($"{tal1} / {tal2} = {division}");
                                string resultat = $"{tal1} / {tal2} = {division}";
                                beräkningar.Add(resultat);
                            }
                            catch (DivideByZeroException e)
                            {
                                WriteLine("Division med noll inte möjligt.");
                            }
                            
                        }
                        WriteLine("Vill du utföra en ny beräkning? (j/n): ");
                        retry = ReadLine();
                        if (retry == "n")
                        {
                            Clear();
                            Menu();
                        }
                        break;

                    case 2:
                        Clear();
                        foreach (string s in beräkningar)
                        {
                            WriteLine(s);
                        }
                        WriteLine("Vill du gå tillbaka till menyn? (j/n): ");
                        string goBack = ReadLine();
                        if (goBack == "j")
                        {
                            Clear();
                            Menu();
                        }
                        else if (goBack == "n")
                        {
                            WriteLine("Tryck valfri tangent för att avsluta...");
                        }
                        ReadKey();
                        break;

                    default:
                        Clear();
                        Run();
                        break;
                }
            } while (retry != "n");
        }

    }
}

