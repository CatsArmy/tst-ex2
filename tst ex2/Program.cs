int maxIndex = 999999;
bool flag = false;
NumWeight.left = new int[maxIndex];
NumWeight.right = new int[maxIndex];
//Input + Instructions
for (int i = 0; i != -1 || flag == true; i++)//temp++ |-old
{    
    Console.WriteLine("Input Left Num");
    NumWeight.left[i] = int.Parse(Console.ReadLine());
    NumWeight.CalculateNumWeight(NumWeight.left[i]);
    NumWeight.totalLeft += NumWeight.CalculateNumWeight(NumWeight.left[i]);
    Console.WriteLine("Input Right Num");
    NumWeight.right[i] = int.Parse(Console.ReadLine());
    NumWeight.CalculateNumWeight(NumWeight.right[i]);
    NumWeight.totalRight += NumWeight.CalculateNumWeight(NumWeight.right[i]);
    
    
    if(NumWeight.totalLeft>999 || NumWeight.totalRight > 999)
    {
        flag = true;
    }
    Console.Clear();
}
Console.Clear();
//Begone 9999999 Have your self a limit cus I MUST HAVE A FIXED SIZED ARRAYYYYY WHY CANT I MAKE IT IsFixedSize = false; AAAA
NumWeight.left = NumWeight.ResetMaxIndex(NumWeight.left, maxIndex);
NumWeight.right = NumWeight.ResetMaxIndex(NumWeight.right, maxIndex);
maxIndex = NumWeight.left.Length;
//Output
for (int i = 0; i < maxIndex; i++)
{
    if(NumWeight.right[i] > NumWeight.left[i])
    {
        Console.WriteLine($"The Right Weight({NumWeight.right[i]}) is Bigger Than The Left Weight({NumWeight.left[i]}) At The Index Of {i}");
    }
    else if (NumWeight.right[i] == NumWeight.left[i])
    {
        Console.WriteLine($"The Weights Are Equal As All Things Should Be At The Index Of {i}");
    }
    else
    {
        Console.WriteLine($"The Left Weight({NumWeight.left[i]}) is Bigger Than The Right Weight({NumWeight.right[i]}) At The Index Of {i}");
    }
}
Console.WriteLine($"The Length Of The Arrays is {maxIndex} ");
public class NumWeight
{
    public static int totalRight
    {
        get;
        set;
    }
    public static int totalLeft
    {
        get;
        set;
    }
    public static int[] right
    {
        get;
        set;
    }
    public static int[] left
    {
        get;
        set;
    }
    public static int[] ResetMaxIndex(int[] otherArr, int maxIndex)
    {
        int[] arr = new int[maxIndex];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = otherArr[i];
        }
        return arr;
    }
    public static int CalculateNumWeight(int num)
    {
        int tempNum;
        int sumOfNum = 0;
        int maxNum = 0;
        while (num != 0)
        {
            sumOfNum += num % 10;
            tempNum = num % 10;
            if (tempNum > maxNum) { maxNum = tempNum; }
            num /= 10;
        }
        int weight = sumOfNum * maxNum;
        return weight;
    }
}