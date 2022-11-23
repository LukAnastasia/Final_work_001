// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Примеры:
// ["hello", "2", "world", ":-)"]
// ["1234","1567","-2","computer since"]
// ["Russia","Denmark","Kazan"]

string[] array1 = new string[] { "hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];
void resultArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
resultArray(array1, array2);
PrintArray(array2);
