// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами. 

string[] array1 = new string[7] {"кто", "hello", "huge", "world", "это", ":)", "?"};
string[] array2 = new string[array1.Length];
int n = 3;
void GeneratedArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= n)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
GeneratedArray(array1, array2);
array2 = array2.Where(x => !string.IsNullOrEmpty(x)).ToArray();
Console.WriteLine($"Массив из строк, длина которых меньше либо равна {n} символа: [ {string.Join(", ", array2)} ]");
