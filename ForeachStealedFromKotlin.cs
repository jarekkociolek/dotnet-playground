//Credits to: https://youtu.be/jmmz1cInNow
public static class CustomLoopExtensions
{
    public static CustomIntEnumerator GetEnumerator(this Range range)
    {
        return new CustomIntEnumerator(range);
    }
}

public ref struct CustomIntEnumerator
{
    private int _current;
    private readonly int _last;
    
    public CustomIntEnumerator(Range range)
    {
        _current = range.Start.Value - 1;
        _last = range.End.Value;
    }

    public int Current => _current;
    public bool MoveNext()
    {
        _current++;
        return _current <= _last;
    }
}