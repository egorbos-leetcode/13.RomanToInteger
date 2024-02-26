namespace Solution;

public static class Solution
{
    public static int RomanToInt(string s) {
        var result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            result += s[i] switch
            {
                'I' => 1,
                'V' when i > 0 && s[i - 1] == 'I' => 3,
                'V' => 5,
                'X' when i > 0 && s[i - 1] == 'I' => 8,
                'X' => 10,
                'L' when i > 0 && s[i - 1] == 'X' => 30,
                'L' => 50,
                'C' when i > 0 && s[i - 1] == 'X' => 80,
                'C' => 100,
                'D' when i > 0 && s[i - 1] == 'C' => 300,
                'D' => 500,
                'M' when i > 0 && s[i - 1] == 'C' => 800,
                'M' => 1000,
                 _  => 0
            };
        }
        return result;
    }
}