namespace something;

public interface INumber
{
    int WholePart { get ; set; }
    int FractionalPart { get ; set; }

    void SetWholePart(int WholePart);
    void SetFractionalPart(int FractionalPart);

    double ToDouble();
}
