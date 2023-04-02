namespace ConvertProject.Logic
{
    public static class ConversionLogic
    {
        public static double ConvertCtoF(double Celcius)
        {
            var convertedUnit = Celcius * 9 / 5 + 32;
            return convertedUnit;
        }

        public static double ConvertFtoC(double Fahrenheit)
        {
            var convertedUnit = (Fahrenheit - 32) * 5 / 9;
            return convertedUnit;
        }
    }
}