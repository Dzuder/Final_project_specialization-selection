using static System.Console;
Clear();

// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

WriteLine("Заполните элементы массива через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}

string[] decision = new string[count];

if (count > 0)
{
    int index = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            decision[index] = array[j];
            index++;
        }
    }

}


WriteLine($"\n[{String.Join(", ", array)}]  ->  [{String.Join(", ", decision)}]");

//                 РЕШЕНИЕ ЧЕРЕЗ МЕТОДЫ 

// WriteLine("Введите слова через пробел: "); 
// string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


// PrintArray(array);
// string[] decision = new string[ResultArrayLength(array)];
// if (decision.Length > 0)
// {
//     GetResultArray(decision, array);
//     Write(" -> ");
//     PrintArray(decision);
// }
// else Write(" -> []");


// void PrintArray(string[] arr)
// {
//     Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Write($"{arr[i]}, ");
//     }
//     Write($"{arr[arr.Length - 1]}]");
// }


// int ResultArrayLength(string[] arr1)
// {
//     int count = 0;
//     for (int i = 0; i < arr1.Length; i++)
//     {
//         if (arr1[i].Length <= 3) count++;
//     }
//     return count;

// }


// void GetResultArray(string[] resArr, string[] arr2)
// {
//     int index = 0;

//     for (int j = 0; j < arr2.Length; j++)
//     {
//         if (arr2[j].Length <= 3)
//         {
//             resArr[index] = arr2[j];
//             index++;
//         }
//     }

// }