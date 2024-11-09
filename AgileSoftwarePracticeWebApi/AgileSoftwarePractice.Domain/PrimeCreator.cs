namespace AgileSoftwarePractice.Domain;

public class PrimeCreator
{
    private int _maxValue = -1;
    private List<bool> _isPrimeList = [];
    private List<int> _primeList = [];

    public void SetMaxValue(int maxValue)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(maxValue, 2);
        _maxValue = maxValue;
    }

    public IEnumerable<int>? Generate(int maxValue)
    {
        Initialize();
        CalculatePrime();
        LoadPrime();
        return _primeList;
    }

    private void LoadPrime()
    {
        var number = 0;
        // 素数の抜き出し
        foreach (var isPrime in _isPrimeList)
        {
            if (isPrime)
            {
                _primeList.Add(number);
            }
            number++;
        }
    }

    private void CalculatePrime()
    {
        _isPrimeList[0] = _isPrimeList[1] = false;
        for (int i = 2; i < Math.Sqrt(_isPrimeList.Count); i++)
        {
            if (_isPrimeList[i])
            {
                for (int j = 2 * i; j < _isPrimeList.Count; j += i)
                {
                    _isPrimeList[j] = false; // 倍数は素数ではない
                }
            }
        }
    }

    /// <summary>
    /// 素数判定リストを作成します。
    /// </summary>
    /// <returns>素数判定リスト</returns>
    private void Initialize()
    {
        for (int i = 0; i < _maxValue; i++)
        {
            _isPrimeList.Add(true);
        }
    }
}
