namespace something;

public class Number
{
    public int WholePart { get; set; }
    public int FractionalPart { get; set; }

    public Number(int WholePart = 0, int FractionalPart = 0)
    {
        this.SetWholePart(WholePart);
        this.SetFractionalPart(FractionalPart);
    }

    public void SetWholePart(int WholePart)
    {
        if (WholePart < 0)
        {
            throw new ArgumentException("WholePart cannot be negative!");
        }

        this.WholePart = WholePart;
    }

    public void SetFractionalPart(int FractionalPart)
    {
        if (FractionalPart < 0)
        {
            throw new ArgumentException("FractionalPart cannot be negative!");
        }

        this.WholePart = this.WholePart + FractionalPart / 100;
        FractionalPart = FractionalPart % 100;

        this.FractionalPart = FractionalPart;
    }

    public double ToDouble()
    {
        double Result = this.WholePart;

        Result = Result + (double)this.FractionalPart / 100;

        return Result;
    }

    public static Number operator +(Number a, Number b)
    {
        double a_double = a.ToDouble();
        double b_double = b.ToDouble();

        return (a_double + b_double).ToNumber();

       // a.WholePart = a.WholePart + b.WholePart;

       // a.WholePart = a.WholePart + ((a.FractionalPart + b.FractionalPart) / 100);
       // a.FractionalPart = (a.FractionalPart + b.FractionalPart) % 100;

       // return a;
    }

    public static Number operator -(Number a, Number b)
    {
        double a_double = a.ToDouble();
        double b_double = b.ToDouble();

        return (a_double - b_double).ToNumber();

       // if (a.WholePart < b.WholePart || (a.WholePart == b.WholePart && b.FractionalPart > a.FractionalPart))
       // {
       //     a.WholePart = a.FractionalPart = 0;
       //     return a;
       // }

       // a.WholePart = a.WholePart - b.WholePart;
       // a.WholePart = a.WholePart - (b.FractionalPart > a.FractionalPart ? 1 : 0);

       // if (a.FractionalPart >= b.FractionalPart)
       // {
       //     a.FractionalPart = a.FractionalPart - b.FractionalPart;
       // }

       // else 
       // {
       //     a.FractionalPart = 100 - Math.Abs(a.FractionalPart - b.FractionalPart);
       // }

       // return a;
    }

    public static Number operator +(Number a, int b)
    {
        return a + (double)b;
    }

    public static Number operator +(Number a, double b)
    {
        int WholePart = (int)b;
        int FractionalPart = (int)((b - (double)WholePart) * 100);

        a.WholePart = a.WholePart + WholePart;

        a.WholePart = a.WholePart + ((a.FractionalPart + FractionalPart) / 100);
        a.FractionalPart = (a.FractionalPart + FractionalPart) % 100;

        return a;
    }
}
