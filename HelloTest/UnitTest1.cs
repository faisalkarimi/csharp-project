namespace HelloTest;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2,2));
    }

    int Add(int a, int b)
    {
        return a + b;
    }
}