// Задача 4**(не обязательно):
//Дано натуральное число в диапазоне от 1 до 100 000.
//Создайте массив, состоящий из цифр этого числа.
//Старший разряд числа должен располагаться на 0-м индексе массива,
//младший – на последнем. Размер массива должен быть равен количеству цифр.
int number = new Random().Next(1, 10_000);
Console.WriteLine($"Число: {number}");
int[] result = new int[1];
while (number/10 != 0)
{
    result[result.Length-1] = number % 10;
    number = number / 10;
    Array.Resize(ref result, result.Length + 1);
}
result[result.Length-1] = number;
Array.Reverse(result);
Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
//Если реверс это тоже читерство то можно так:
int number2 = new Random().Next(1, 10_000);
Console.WriteLine($"Число: {number2}");
int[] resultSecond = new int[1];
while (number2/10 != 0)
{
    resultSecond[resultSecond.Length-1] = number2 % 10;
    number2 /= 10;
    Array.Resize(ref resultSecond, resultSecond.Length + 1);
}
resultSecond[resultSecond.Length-1] = number2;
int[] resultFinal = new int[resultSecond.Length];
for (int i=0; i<resultFinal.Length; i++)
{
    resultFinal[i] = resultSecond[resultSecond.Length-i-1];
}
Console.WriteLine($"Результат: [{string.Join(", ", resultFinal)}]");