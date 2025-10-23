using GPSSabores.Application.Services.Cryptography;

namespace CommonTestUtilities.Cryptography;
public class PasswordEncrypterBuilder
{
    public static PasswordEncripter Build() => new PasswordEncripter("abc1234");
}
