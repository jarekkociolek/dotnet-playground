//Credits to: https://youtu.be/s9mMWtFXJHM
public interface ICaller
{
    void Call();
}

public class Caller : ICaller
{
    public void Call()
    {
        throw new NotImplementedException();
    }
}