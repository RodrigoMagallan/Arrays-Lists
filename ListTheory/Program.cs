//Rectangular array declaration
var matrix = new int[3, 5]
{
    { 1, 2, 3, 4,0 },
    {4,5,6,7,0 },
    {10,6,4,23,0 }
};

Console.WriteLine(matrix[2, 0]);

//Jagged Array Declaration
var jagged = new int[3][];
jagged[0]= new int[3];
jagged[1]= new int[5];
jagged[2]= new int[4];

//Length
//Clear()
//IndexOf() find the position of an element
//Reverse()
//Sort()

var numbers = new int[] { 3, 7, 8, 9, 14, 6 };
//Length
Console.WriteLine("The Length is: " + numbers.Length);
//IndexOf   
var index = Array.IndexOf(numbers, 14);
Console.WriteLine("The index of 14 is: " + index);
//Clear
Array.Clear(numbers, 0, 2);
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

//Copy
int[] another = new int[3];
Array.Copy(numbers, another, 3);
Console.WriteLine("Copyy() effect");
foreach (var m in another)
{
    Console.WriteLine(m);
}
//Sort
Array.Sort(numbers);
Console.WriteLine("Effect of sort()");
foreach (var m in numbers)
{
    Console.WriteLine(m);
}
//Reverse
Array.Reverse(numbers);
Console.WriteLine("Effect of Reverse");
foreach (var n in numbers)
{
    Console.WriteLine(n);
}
// Lists
Console.WriteLine("LISTS\n");
var numberList = new List<int>() {1,2,3,4,5,6,7 }; //List of integers
//Useful methods Add() AddRange() Remove() RemoveAt() IndexOf() Contains() Count

var intList = new List<int>() { 1, 2, 3, 4 };
intList.Add(1);
intList.AddRange(new int[3] { 6, 7, 8 });

foreach (var n in intList)
{
    Console.WriteLine(n);
}

Console.WriteLine("The index of 1: " + intList.IndexOf(1));
Console.WriteLine("The last index of 1: " + intList.LastIndexOf(1));
Console.WriteLine("Count: " + intList.Count);

Console.WriteLine("remover ");

for (int i = 0; i < intList.Count; i++)
{
    if (intList[i] == 1)
        intList.Remove(intList[i]);
}

foreach (var n in intList)
{
    Console.WriteLine(n);
}

intList.Clear();
Console.WriteLine("Count: " + intList.Count);