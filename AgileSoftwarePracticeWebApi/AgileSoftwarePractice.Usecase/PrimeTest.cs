using AgileSoftwarePractice.Domain;

namespace AgileSoftwarePractice.Usecase;

public class PrimeTest
{
    [Fact]
    public void TestGeneratePrime()
    {
        var input = 10;
        var prime = new PrimeCreator();
        var act = prime.Generate(input);
        Assert.Equal([2, 3, 5, 7], act);
    }
}