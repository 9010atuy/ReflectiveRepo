namespace AgileSoftwarePractice.Domain.DIP;

public class ThermalControl
{
    private readonly Heater _heater;
    private readonly Thermometer _thermometer;
    public ThermalControl(Heater heater, Thermometer thermometer)
    {
        _heater = heater;
        _thermometer = thermometer;
    }

    public void Regulate(double minTemp, double maxTemp)
    {
        var currentTemplature = _thermometer.ReadTemparature();
        if (IsRegularTemplate(minTemp, maxTemp, currentTemplature)) { return; }
        if (currentTemplature < minTemp)
        {
            _heater.Raise(minTemp);
        }
        else
        {
            _heater.Lower(maxTemp);
        }
    }

    private static bool IsRegularTemplate(double minTemp, double maxTemp, double currentTemplature)
    {
        return currentTemplature > minTemp && currentTemplature < maxTemp;
    }
}
