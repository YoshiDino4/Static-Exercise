namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheitTemp)
    {
        return (fahrenheitTemp - 32) * 5 / 9;
    }

    public static double CelsiusToFahrenheit(double celsiusTemp)
    {
        return (celsiusTemp * 9 / 5) + 32;
    }
}