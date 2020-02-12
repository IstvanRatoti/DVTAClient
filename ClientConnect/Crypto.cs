using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataHandling
{
    public class Crypto
    {

        // Creates a sha1 hash for a given password.
        public static string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA1Managed sha1 = new System.Security.Cryptography.SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
