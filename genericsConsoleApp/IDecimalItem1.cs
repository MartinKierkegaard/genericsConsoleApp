namespace genericsConsoleApp
{
    public interface IDecimalItem1
    {
        decimal CalculateSum();
    }
    public interface ICalculate<T>
    {
        T CalculateSum();
    }

}