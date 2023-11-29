using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Implementations;

public abstract class Shape : IShape
{
    public abstract double GetPerimeter();
    public abstract double GetArea();

    protected void ValidatePositiveValues(params double[] values)
    {
        ValidatePositiveValues(values.Select((value, index) => (index.ToString(), value)).ToArray());
    }

    protected void ValidatePositiveValues(params (string name, double value)[] values)
    {
        var validationErrors = new List<Exception>();

        foreach (var (name, value) in values)
        {
            if (value <= 0)
            {
                validationErrors.Add(new ArgumentException($"Value must be a positive number", name));
            }
        }

        if (validationErrors.Count > 0)
        {
            throw new AggregateException(validationErrors);
        }
    }
}