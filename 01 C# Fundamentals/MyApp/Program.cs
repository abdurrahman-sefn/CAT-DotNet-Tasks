/*
This is a LeetCode challenge I solved with C#!
 
Problem statement:
You are given a string s consisting only of the characters '0' and '1'. In one operation, you can change any '0' to '1' or vice versa.

The string is called alternating if no two adjacent characters are equal. For example, the string "010" is alternating, while the string "0100" is not.

Return the minimum number of operations needed to make s alternating.
*/
public class Solution {
    char Flip(char c)
    {
        if (c == '0')
        {
            return '1';
        }
        return '0';
    }
    public int MinOperations(string s) {
        char state = '0';
        int cnt1 = 0, cnt2 = 0;
        foreach (char c in s)
        {
            if (c != state)
            {
                ++cnt1;
            }
            else
            {
                ++cnt2;
            }
            state = Flip(state);
        }
        return Math.Min(cnt1, cnt2);
    }
}
