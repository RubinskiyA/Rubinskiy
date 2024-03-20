//Console.WriteLine($"{Math.PI:F2}");
//Console.WriteLine($"{Math.E:F1}");

Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = double.Parse(Console.ReadLine());
Console.Write("Введите четвертое число: ");
double d = double.Parse(Console.ReadLine());

Console.WriteLine($"Вот ваши числа:\n"+$"{a}\n" +
    $"{b}\n" +
    $"{c} \n" +
    $"{d}");