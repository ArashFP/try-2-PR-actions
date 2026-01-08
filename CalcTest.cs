using Xunit;   

public class CalcTest
{
    [Fact]
    public void TestAddition()
    {
        var calc = new Calc();
        int result = calc.Add(2, 3);
        Assert.Equal(5, result);
    }
}