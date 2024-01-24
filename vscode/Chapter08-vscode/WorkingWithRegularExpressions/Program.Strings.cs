partial class Program
{
    const string digitsOnlyText = @"^\d+$";
    const string commaSeparatorText = "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";
}