//Тема 4 Урок 1-2 
//Задача 1
double Moskvichi = 13015126;
double Peterburgci = 5598486;
double raznica = Moskvichi - Peterburgci;
double otvet = raznica / 1000;
Console.WriteLine($"Жителей Москвы на {otvet} тысяч больше, чем в Санкт-Петербурге");

//Задача 2
decimal plataYear = 260548.56895M;
decimal plataMonth = plataYear / 12;
decimal plataMonth_NDFL = plataMonth * 0.87M;
Console.WriteLine($"Работник получает {plataMonth:F2} в месяц, а с вычетом НДС - {plataMonth_NDFL:F2}");



