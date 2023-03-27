// Из имеющегося массива строк сформировать массив строк, длина которых 
//меньше или равна 3-м символам.

// ввод строкового массива с данными
string[] array1 = new string[4] {"hello", "2", "world", "-)"};
// инициация второго строкового массива с количеством элементов(строк), равному длине(размеру) массива 1
string[] array2 = new string[array1.Length];

// заполнение 2-го массива элементами первого с условием:
// массив из строк, длина которых не более 3-х символов. 

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if(array1[i].Length <= 3)
    {
    array2[count] = array1[i];
    count++;
    }
}
// Метод - создание - печать элементов массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// Запуск метода - печать 2-го (заполненного) 
PrintArray(array2);