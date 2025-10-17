using System.Security.Cryptography;
using System.Text;

namespace GPSSabores.Application.Services.Cryptography;

public class PasswordEncripter
{
    private readonly string _additionalKey;
    public PasswordEncripter(string additionalKey) => _additionalKey = additionalKey;

    public string Encrypt(string password)
    {


        var newPassword = $"{password}{_additionalKey}";
        var bytes = Encoding
            .UTF8.GetBytes(newPassword);
        var hashBytes = SHA512.HashData(bytes);

        return StringBytes(hashBytes);
    }

    private static string StringBytes(byte[] bytes)
    {
        var db = new StringBuilder();
        foreach (byte b in bytes)
        {
            var hex = b.ToString("x2");
            db.Append(hex);
        }
        return db.ToString();
    }

}

