
namespace AgileSoftwarePractice.Domain;

public class PrimeCreator
{
    public IEnumerable<int>? Generate(int maxValue)
    {
        if (maxValue < 2)
        {
            return null;
        }

        var arraySize = maxValue + 1;
        bool[] primeJudgeArray = new bool[arraySize];
        int i;

        // 初期化
        for (i = 0; i < arraySize; i++)
        {
            primeJudgeArray[i] = true;
        }

        // 周知の非素数を取り除く
        primeJudgeArray[0] = primeJudgeArray[1] = false;

        // ふるい落とす
        int j;
        for (i = 2; i < Math.Sqrt(arraySize); i++)
        {
            if (primeJudgeArray[i])
            {
                for (j = 2 * i; j < arraySize; j += i)
                {
                    primeJudgeArray[j] = false; // 倍数は素数ではない
                }
            }
        }

        // 見つけた素数の個数をカウント
        int count = 0;
        for (i = 0; i < arraySize; i++)
        {
            if (primeJudgeArray[i])
            {
                count++;
            }
        }

        int[] primes = new int[count];

        // 素数の抜き出し
        for (i = 0, j = 0; i < arraySize; i++)
        {
            if (primeJudgeArray[i])
            {
                primes[j++] = i;
            }
        }
        return primes;
    }
}
