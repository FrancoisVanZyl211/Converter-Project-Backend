namespace ConvertProject.Logic
{
    public static class ConversionLogic
    {
        public static double ConvertCtoF(double unit)
        {
            var convertedUnit = unit * 9 / 5 + 32;
            return convertedUnit;
        }
    }
}