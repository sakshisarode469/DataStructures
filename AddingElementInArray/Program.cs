int[] arr = { 10, 20, 30, 40, 50 };

int deleteIndex = 0;
if (deleteIndex >= 0 && deleteIndex < arr.Length)
{
    for (int i = deleteIndex; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }

    arr[arr.Length - 1] = 0;


    Console.WriteLine($"Element at index{deleteIndex} deleted");
}
else
{
    Console.WriteLine("Invalid Deletion");
}

Console.WriteLine("Updated Array is");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Index {i}:{arr[i]}");
}