void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
}
 
 void PrintArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}    ");

    }
    Console.WriteLine();
 }
 
 
 
 
 
 void Task25()
{
  //Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа
  // (A и B) и возводит число A в степень B.
    int a = 5;
    int b = 3;

    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }

    Console.WriteLine($"{a}^{b} = {result}");

}

void Task27()
{
//Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
    int number = 23415;

    int sum = 0;

    Console.WriteLine($"Сумма цифр числа {number} равна ");

    while (number > 0)
    {
        sum += number%10; 
        number /= 10;
    }
    Console.WriteLine(sum);
}

void Task29()
//Задача 29: Напишите программу, которая задаёт массив
//из 8 случайных целых чисел и выводит отсортированный
//по модулю массив.
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int lastIndex = numbers.Length - 1;
    for (int i = 0; i < lastIndex; i++)
    {
        for (int k = 0; k < lastIndex - i; k++)
        {
            if (numbers[k] > numbers[k + 1])
            {
                int temp = numbers[k];
                numbers[k] = numbers[k + 1];
                numbers[k + 1] = temp;
            }
        }
    }
    Console.WriteLine();
    
}
Task29();










 
    
