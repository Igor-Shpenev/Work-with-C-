// Напишите программу, которая выводит случайное  число из отрезка [10, 99]и показывает наибольшую цифру числа

/*int FindBiggestDigit(int number)

{
    int ed = number % 10;               //единицы
    int dec = number / 10;               //десятки
    int result;

    if (ed > dec)
    {
        result = ed;
    }
    else
    {
        result = dec;
    }
    return result;
}

int randNum = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(randNum);

Console.WriteLine($"The biggest digit of {randNum} is {biggestDigit}");*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


/*int DeleteSecondDigit(int num)
{
    int digit1 = num / 100;  //кол-во сотен (например: 354 -> 3)
    int digit3 = num % 10;  //кол-во едениц (например: 354 -> 4)
    int res = digit1 * 10 + digit3; // 3 * 10 +4
    return res;
}
int randNum = new Random().Next(100, 1000);
int result = DeleteSecondDigit(randNum);

Console.WriteLine($"Result of convertation {randNum} is {result}");*/
