//Debugger attributes
// var user = new User { FirstName = "John", LastName = "Doe"};
// Console.ReadKey();

//Regex best settings
var email = "john.doe@johndoe.com";
Console.WriteLine($"Is email: {email} valid? Result: {RegexValidators.ValidateEmail(email)}");