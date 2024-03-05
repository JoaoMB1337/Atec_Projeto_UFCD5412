using System.Security.Cryptography;
using System.Text;

namespace Projeto_UFCD5412.Controller
{
    internal class EncryptController
    {
        private static string EncryptPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private static string DecryptPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = new byte[password.Length / 2];
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashBytes[i] = byte.Parse(password.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
                }

                byte[] decryptedBytes = md5.TransformFinalBlock(hashBytes, 0, hashBytes.Length);

                string decryptedPassword = Encoding.ASCII.GetString(decryptedBytes);

                return decryptedPassword;
            }
        }


        public static string EncryptPasswordStatic(string password)
        {
            return EncryptPassword(password);
        }

        public static string DecryptPasswordStatic(string password)
        {
            return DecryptPassword(password);
        }
    }
}
