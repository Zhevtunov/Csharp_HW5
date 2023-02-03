// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int EvenNumbers(int[] arr)
{
  int count = 0;
  int length = arr.Length;
  for (int i = 0; i < length; i++)
  {
    if (arr[i] % 2 == 0) count += 1;
  }
  return count;
}

int[] FillArray(int number, int num1, int num2)
{
  int[] arr = new int[number];
  for (int i = 0; i < number; i++)
  {
    arr[i] = new Random().Next(num1, num2);
  }
    return arr;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num = GetNum("Из скольки элементов составить массив?: ");
int[] array = FillArray(num, 100, 999);
int quantity = EvenNumbers(array);
Console.WriteLine("[" + String.Join(", ", array) + "]");
Console.WriteLine("Массив содержит -> " + quantity + " четных элемента(-ов)");