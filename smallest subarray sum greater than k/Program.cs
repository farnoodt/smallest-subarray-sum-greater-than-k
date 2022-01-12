// See https://aka.ms/new-console-template for more information
int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };
int k = 21;

// find the length of the smallest subarray
Console.WriteLine(findSmallestSubarrayLen(A, k));


static int findSmallestSubarrayLen(int[] A, int k)
{
    int left = 0;
    int sum = 0;
    int len = int.MaxValue;

    for (int right = 0; right < A.Length; right++)
    {
        sum += A[right];
        while (sum > k)
        {
            len = Math.Min(len, right - left+1);
            sum -= A[left];
            left++;
            if(sum>k)
                len = Math.Min(len, right - left+1);
        }
    }
    return len;
}
