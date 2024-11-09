using AgileSoftwarePractice.Domain;

namespace AgileSoftwarePractice.Usecase;

public class PrimeTest
{
    [Fact]
    public void TestGeneratePrime()
    {
        var input = 10;
        var primeCreator = new PrimeCreator();
        primeCreator.SetMaxValue(input);
        var act = primeCreator.Generate(input);
        Assert.Equal([2, 3, 5, 7], act);
    }
}