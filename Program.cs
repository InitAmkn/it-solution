
//На любом языке программирования написать программный код,
//который перебирает целые числа от 0 до бесконечности и выводит на экран те,
//которые делятся без остатка на количество разрядов (знаков)
//этого числа(т.е.те двухзначные, которые делятся на 2, трехзначные на три и т.д.).
//Выполнение обработки должно остановиться в тот момент,
//когда всего будет выведено N (задается пользователем) таких чисел.

//Результат нужно предоставить в виде:

//1) исходный код
//2) результат выполнения кода для N = 28, 120, 500




enumerationOfNumbers(input());


void enumerationOfNumbers(int n)
{ 
    int number = 1;
    while (n > 0)
    {
        if (number % countDigits(number) == 0)
        {
            Console.WriteLine($"{number}");
            n--;
        }
        number++;
    }
}

int input()
{
    Console.Write("Введите число N: "); //Не допускается ввод других символов кроме цифр
    String something = Console.ReadLine();
    int n = 0;
    try
    {
        n = Convert.ToInt32(something);
    }
    catch
    {
        return input();
    }
    return n;
}


int countDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

