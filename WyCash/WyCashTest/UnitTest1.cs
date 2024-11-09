using WyCash;

namespace WyCashTest;

// todo: テストクラス名を適切にする
public class UnitTest1
{
    [Fact]
    // todo: テストメソッド名を適切にする
    // todo: $5 * 2 = $10
    public void Test1()
    {
        Doller five = new(5);
        Doller ten = five.Times(2);
        Assert.Equal(5 * 2, ten.Value);
    }

    // todo: $5 * 10 CHE = $10
}