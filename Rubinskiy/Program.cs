﻿// Тема 4 Урок 1-2
//int Moskvichi = 13015126;
//int Peterburgci = 5598486;
//int raznica = Moskvichi-Peterburgci;
//int otvet = raznica / 1000;
//Console.WriteLine($"Жителей Москвы на {raznica} тысяч больше, чем в Санкт-Петербурге");

//Тема 5 Урок 1
Console.Write("Введите количество миллиметров:");
const double MilliToSanti = 10;
const double MilliToMetr = 1000;
const double MilliToKillo = 1000000;
const double MilliToMile = 1609344;
const double MilliToYards = 0.0010936100483;
double millimetrs = double.Parse(Console.ReadLine());
double santimetrs = millimetrs / MilliToSanti;
double meters = millimetrs / MilliToMetr;
double killometers = millimetrs / MilliToKillo;
double mile = millimetrs / MilliToMile;
double yards = millimetrs * MilliToYards;
Console.WriteLine($"Сантиметров:{santimetrs}\nМетров:{meters}\nКилометров:{killometers}\nМиль:{mile}\nЯрдов:{yards}");
