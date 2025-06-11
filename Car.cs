namespace Homework2_week2;

public class Car
{
    public string Make;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;

    public void Drive(int miles)
    {
        Mileage += miles;
    }

    public void AddFuel(double galloons)
    {
      Fuel += galloons;
    }

}