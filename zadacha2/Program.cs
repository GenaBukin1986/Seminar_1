﻿Console.Clear();
string n = Console.ReadLine();
if (n == "1") Console.Write("пн");
if (n == "2") Console.Write("вт");
if (n == "3") Console.Write("ср");
if (n == "4") Console.Write("чт");
if (n == "5") Console.Write("пт");
if (n == "6") Console.Write("сб");
if (n == "7") Console.Write("вс");
if (int.Parse(n) < 1 || int.Parse(n) > 7) Console.Write("Error");