using System.Runtime.CompilerServices;

int[] arr = { 10, 20, 30, 40, 50 };
Console.WriteLine("Original Array is");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Array {i}:{arr[i]}");
}
int updateIndex = 2;
int newValue = 88;

if (updateIndex >= 0 && updateIndex < arr.Length)
{
    arr[updateIndex] = newValue;
    Console.WriteLine($"Value of index {updateIndex} updated to {newValue}");

}
else
{
    Console.WriteLine($"Invalid Index Update Fails");
}

Console.WriteLine("Updated Array:");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Index {i} : {arr[i]}");
}