int[] arr = new int[5];

arr[0] = 10;
arr[1] = 20;
arr[2] = 30;
arr[3] = 40;

arr[arr.Length - 1] = 50;


Console.WriteLine("Array after inserting at last positon");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Index {i}:{arr[i]}");
}