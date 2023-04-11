// See https://aka.ms/new-console-template for more information
Console.WriteLine("task43");

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double userInput(string name){
    Console.Write($"enter {name} = ");
    return double.Parse(Console.ReadLine());
}

void main(){
    double k1 = userInput("k1");
    double b1 = userInput("b1");
    double k2 = userInput("k2");
    double b2 = userInput("b2");

    if (k1==k2) {
        Console.WriteLine("Прямые параллельны");
        return;
    }

    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;

    Console.WriteLine($"{k1}x+{b1} пересекает {k2}x+{b2} в точке ({x}, {y})");
    return;
}

main();