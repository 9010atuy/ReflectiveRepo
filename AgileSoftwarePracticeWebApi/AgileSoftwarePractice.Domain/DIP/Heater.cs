namespace AgileSoftwarePractice.Domain.DIP;

public interface Heater
{
    bool IsRaise();
    void Lower(double maxTemp);
    void Raise(double minTemp);
}