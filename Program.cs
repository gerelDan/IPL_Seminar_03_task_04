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