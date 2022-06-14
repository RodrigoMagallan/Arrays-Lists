//Write a program and ask the user to supply a list of comma separated numbers, if the list is empty of includes less that 5 numbers, display "invalid list" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list

var newArray = new List<int>();

while (true)
{
    Console.WriteLine("Insert a list of 5 numbers separated by comma: ");
    var number = Console.ReadLine();
    newArray = number.ToString().Split(',').Select(i => int.Parse(i)).ToList();
    if (newArray.Count<5)
    {
        Console.WriteLine("Invalid List, Try Again! ");
        newArray.Clear();
        continue;
    }
    else
    {
        newArray.Sort();
        break;
        //Console.WriteLine("The 3 smallest numbers are{0},{2},{3}: ", newArray[0], newArray[1], newArray[2] );
    }

}

for (int i = 0; i < newArray.Count-2; i++)
{
    Console.WriteLine(newArray[i]);
}







