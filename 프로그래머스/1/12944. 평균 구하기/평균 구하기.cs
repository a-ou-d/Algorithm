public class Solution {
    public double solution(int[] arr)
    {
        double answer = 0;
        
        foreach (int num in arr)
        {
            answer += num;
        }
        
        double average = answer / arr.Length;
        
        return average;
    }
}