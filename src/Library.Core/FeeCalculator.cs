namespace Library.Core;

public class FeeCalculator
{
    public decimal Calculate(DateTime due, DateTime returned)
    {
        var daysLate = (returned.Date - due.Date).Days;
        return daysLate * 5m;
    }
}
