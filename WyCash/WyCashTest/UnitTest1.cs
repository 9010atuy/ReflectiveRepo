using WyCash;

namespace WyCashTest;

// todo: �e�X�g�N���X����K�؂ɂ���
public class UnitTest1
{
    [Fact]
    // todo: �e�X�g���\�b�h����K�؂ɂ���
    // todo: $5 * 2 = $10
    public void Test1()
    {
        Doller five = new(5);
        Doller ten = five.Times(2);
        Assert.Equal(5 * 2, ten.Value);
    }

    // todo: $5 * 10 CHE = $10
}