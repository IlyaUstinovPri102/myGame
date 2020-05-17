using System;
using System.IO;

namespace zadanie_na_pary1
{
    class Files
    {
        public string[] text = File.ReadAllText("primer.txt").Split(new char[] { ';', ' ', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculated Call = new Calculated();
            Call.Calculatede();
        }
    }
    class Peremen
    {
        public string peremen_name;
        public int peremen_chislo;
    }
    class Calculated
    {
        public void Calculatede()
        {
            Peremen PeremenInfo = new Peremen();
            Files dano = new Files();
            int dlina = dano.text.Length;
            for (int i = 0; i < dlina; i++)
            {
                switch (dano.text[i])
                {
                    case "var":
                        Console.WriteLine("---------------VAR---------------");
                        PeremenInfo.peremen_name = dano.text[i + 1];
                        Console.WriteLine($"Новая переменная: {PeremenInfo.peremen_name}");
                        break;
                    case "mov":
                        Console.WriteLine("---------------MOV---------------");
                        Console.WriteLine($"mov {PeremenInfo.peremen_name}, {dano.text[i + 2]}");
                        PeremenInfo.peremen_chislo = int.Parse(dano.text[i + 2]);
                        Console.WriteLine($"{PeremenInfo.peremen_name} = {PeremenInfo.peremen_chislo} ");
                        break;
                    case "add":
                        Console.WriteLine("---------------ADD---------------");
                        Console.WriteLine($"add {PeremenInfo.peremen_name}, {dano.text[i + 2]}");
                        PeremenInfo.peremen_chislo = PeremenInfo.peremen_chislo + int.Parse(dano.text[i + 2]);
                        Console.WriteLine($"{PeremenInfo.peremen_name} = {PeremenInfo.peremen_chislo}");
                        break;
                    case "sub":
                        Console.WriteLine("---------------SUB---------------");
                        Console.WriteLine($"sub {PeremenInfo.peremen_name}, {dano.text[i + 2]}");
                        PeremenInfo.peremen_chislo = PeremenInfo.peremen_chislo - int.Parse(dano.text[i + 2]);
                        Console.WriteLine($"{PeremenInfo.peremen_name} = {PeremenInfo.peremen_chislo}");
                        break;
                    case "div":
                        Console.WriteLine("---------------DIV---------------");
                        Console.WriteLine($"div {PeremenInfo.peremen_name}, {dano.text[i + 1]}");
                        PeremenInfo.peremen_chislo = PeremenInfo.peremen_chislo / int.Parse(dano.text[i + 1]);
                        Console.WriteLine($"{PeremenInfo.peremen_name} = {PeremenInfo.peremen_chislo}");
                        break;
                    case "mul":
                        Console.WriteLine("---------------MUL---------------");
                        Console.WriteLine($"mul {PeremenInfo.peremen_name}, {dano.text[i + 1]}");
                        PeremenInfo.peremen_chislo = PeremenInfo.peremen_chislo * int.Parse(dano.text[i + 1]);
                        Console.WriteLine($"{PeremenInfo.peremen_name} = {PeremenInfo.peremen_chislo}");
                        break;
                }
            }
        }

    }
}
