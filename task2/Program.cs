// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


int SumElemOddPosition(int[] arr)
{
  int result = 0;
  int length = arr.Length;
  for (int i = 0; i < length; i++)
  {
    if (i % 2 != 0) result += arr[i];
  }
  return result;
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
int sumElements = SumElemOddPosition(array);
Console.WriteLine("[" + String.Join(", ", array) + "]");
Console.Write("сумма элементов, стоящих на нечётных позициях массива -> " + sumElements);