namespace Solution.Tests;

public class UnitTest
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Test(string s, int expected)
    {
        var result = Solution.RomanToInt(s);

        Assert.Equal(expected, result);
    }
}