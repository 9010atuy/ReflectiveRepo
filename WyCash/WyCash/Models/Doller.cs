
namespace WyCash;

public class Doller
{
    public decimal Value { get; }

    public Doller(decimal value)
    {
        this.Value = value;
    }

    public Doller Times(int times)
    {
        return new Doller(this.Value * times);
    }
}