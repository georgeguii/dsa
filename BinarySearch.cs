namespace study_dsa;

public static class BinarySearch
{
    public static int Handler(int[] arr, int n)
    {
        var leftPointer = 0;
        var rigthPointer = arr.Length - 1;
        var steps = 0;

        while (leftPointer <= rigthPointer)
        {
            steps++;
            var middlePosition = leftPointer + (rigthPointer - leftPointer) / 2;

            if (arr[middlePosition] == n)
            {
                Console.WriteLine($"Encontado em {steps} tentativas.");
                return middlePosition;
            }
            
            if (arr[middlePosition] < n)
                leftPointer = middlePosition + 1;                
            else
                rigthPointer = middlePosition - 1;
        }

        return -1;
    }
}