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
    }

    public static Number operator -(Number a, Number b)
    {
        double a_double = a.ToDouble();
        double b_double = b.ToDouble();

        if (b_double > a_double)
        {
            return 0.0.ToNumber();
        }

        return (a_double - b_double).ToNumber();
    }

    public static Number operator *(Number a, Number b)
    {
        double a_double = a.ToDouble();
        double b_double = b.ToDouble();

        return (a_double * b_double).ToNumber();
    }

    public static Number operator /(Number a, Number b)
    {
        double a_double = a.ToDouble();
        double b_double = b.ToDouble();

        if (a_double == 0)
        {
            return a;
        }

        return (a_double * b_double).ToNumber();
    }

    public static Number operator +(Number a, double b)
    {
        double a_double = a.ToDouble();

        if (b > a_double)
        {
            return 0.0.ToNumber();
        }

        return (a_double + b).ToNumber();
    }

    public static Number operator -(Number a, double b)
    {
        double a_double = a.ToDouble();

        return (a_double - b).ToNumber();
    }

    public static Number operator *(Number a, double b)
    {
        double a_double = a.ToDouble();

        return (a_double * b).ToNumber();
    }

    public static Number operator /(Number a, double b)
    {
        if (b == 0)
        {
            return a;
        }

        double a_double = a.ToDouble();

        return (a_double / b).ToNumber();
    }

    public static Number operator +(Number a, int b)
    {
        return a + (double)b;
    }

    public static Number operator -(Number a, int b)
    {
        return a - (double)b;
    }

    public static Number operator *(Number a, int b)
    {
        return a * (double)b;
    }

    public static Number operator /(Number a, int b)
    {
        return a / (double)b;
    }
}
