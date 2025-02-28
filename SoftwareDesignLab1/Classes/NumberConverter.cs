namespace something;

public static class NumberConverter
{
    public static Number ToNumber(this double Number)
    {
        int WholePart = (int)Number;

        int FractionalPart = (int)((Number - WholePart) * 100);

        return new Number(WholePart, FractionalPart);
    }
}
