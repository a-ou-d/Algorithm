using System;

public class Solution
{
    public int solution(int n)
    {
        string numbers = n.ToString();
        
        int answer = 0;
        
        foreach (char numarr in numbers)
        {
            answer += (int)Char.GetNumericValue(numarr);
        }
        
        return answer;
    }
}