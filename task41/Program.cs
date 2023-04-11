// See https://aka.ms/new-console-template for more information
Console.WriteLine("task41");

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 !!!ошибка в примере к задаче!!!*/

int[] arrayInput(){
    Console.Write("enter size of array = ");
    int M = int.Parse(Console.ReadLine());
    int[] array = new int[M]; 
    for (int i=0; i<M; i++){
        Console.Write($"enter element #{i} = ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int countPositives(int[] array){
    int result = 0;
    for (int i=0; i<array.Length; i++){
        if (array[i]>0) result++;
    }
    return result;
}

void test(){
    Console.WriteLine(countPositives(arrayInput()));
}

test();