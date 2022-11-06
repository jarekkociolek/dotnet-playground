//Credits to: https://youtu.be/yAaDn_-0rZY
using System.Diagnostics;

[DebuggerDisplay("User: {FirstName} {LastName}")]
public class User
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int Age { get; set; }
}