int[] array = {0,1,2,3, 4, 5,6,7,8}; // Array with odd length
//int[] array = {0,1,2,3,4, 5,6,7,8,9}; // Array with even length
// int[] array = {0,1};
// int[] array = {1};

#region PRINTSTATEMENTS
Console.Write("Array: ");
for(int i = 0; i< array.Length; i++)
    Console.Write(array[i]+" ");
Console.WriteLine();
#endregion

int temp = 0;
for(int i = 0; i< array.Length/2; i++) // O(n) in-place 
{
    temp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = temp;
}

#region PRINTSTATEMENTS
Console.Write("Reversed array: ");
for(int i = 0; i < array.Length; i++)
    Console.Write(array[i]+" ");
#endregion