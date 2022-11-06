//DEBUGGER USEFUL ATTRIBUTES
// var user = new User { FirstName = "John", LastName = "Doe"};
// Console.ReadKey();

//REGEX GOOD PRACTICES
//AppDomain.CurrentDomain.SetData("REGEX_DEFAULT_MATCH_TIMEOUT", TimeSpan.FromSeconds(1)); - this can be set GLOBALLY
// var email = "john.doe@johndoe.com";
// Console.WriteLine($"Is email: {email} valid? Result: {RegexValidators.ValidateEmail(email)}");

//FOREACH STEALED FROM KOTLIN
foreach(var i in 0..10)
{
    Console.WriteLine(i);
}
