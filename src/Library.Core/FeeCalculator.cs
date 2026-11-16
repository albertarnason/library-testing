namespace Library.Core;

public class FeeCalculator
{
    public decimal Calculate(DateTime due, DateTime returned)
    {
        var daysLate = (returned.Date - due.Date).Days;
        return Math.Max(0, daysLate) * 5m;
    }
}
