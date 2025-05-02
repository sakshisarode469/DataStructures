using System;

public class Program
{
    public static void Main()
    {
        // 1. Declaration and Initialization
        int[] numbers = new int[5];

        // 2. Insertion
        numbers[0] = 11;
        numbers[1] = 22;
        numbers[2] = 33;
        numbers[3] = 44;
        numbers[4] = 55;

        // 3. Accessing
        Console.WriteLine("Element at index 3:"  + numbers[3]);

        // 4. Updating value in array at index 2
        numbers[2] = 99;
        Console.WriteLine("Updated index 2: " + numbers[2]);

        // 5. Traversal
        Console.WriteLine("All elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index {i}: {numbers[i]}");
        }

        // 6. Searching element 44 in array
        int searchValue = 44;
        int index = Array.IndexOf(numbers, searchValue);
        if (index != -1)
            Console.WriteLine($"{searchValue} found at index {index}");
        else
            Console.WriteLine($"{searchValue} not found");

        // 7. Sorting of Array
        Array.Sort(numbers);
        Console.WriteLine("Sorted array: " + string.Join(" ", numbers));

        // 8. Reversing the Array
        Array.Reverse(numbers);
        Console.WriteLine("Reversed array: " + string.Join(" ", numbers));

        // 9. Length of Array
        Console.WriteLine("Array length: " + numbers.Length);

       
    }
}
