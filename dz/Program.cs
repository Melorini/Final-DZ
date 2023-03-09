// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше либо равна трём символам. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] myArray = new string[8] {"hello", "1234", "world", "-2", "Kazan", "Lot", "80", "Top"};
string[] newArray = new string[myArray.Length];
void pickFromArray(string[] myArray, string[] newArray)
{
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
if(myArray[i].Length <= 3)
{
newArray[count] = myArray[i];
count++;
}
}
}

void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(" " +array[i]);
}
Console.WriteLine();
}

PrintArray(myArray);
pickFromArray(myArray, newArray);
PrintArray(newArray);