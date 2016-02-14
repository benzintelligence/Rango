using Rango.Common.Resources.Errors;

namespace Rango.Common.Validation
{
    public class PasswordAssertionConcern
    {
        public static bool AssertIsValid(string password)
        {
            return AssertionConcern.AssertArgumentEmpty(password, Errors.PasswordIntervalCaractere);
        }

        public static string Encrypt(string password)
        {
            password += "|2d331cca-f6c0-40c0-bb43-6e32989c2881";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(password));
            System.Text.StringBuilder sbString = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sbString.Append(data[i].ToString("x2"));
            return sbString.ToString();
        }
    }
}
