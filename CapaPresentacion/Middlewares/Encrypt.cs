using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Middlewares
{
    public class Encrypt
    {
        // This code snippet is responsible for comparing
        //the password with the "Hash" stored in the database
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] stream = null;

            StringBuilder sb = new StringBuilder();

            stream = sha256.ComputeHash(encoding.GetBytes(str));

            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();
        }

        //This piece of code is responsible for converting the password
        //that is created into a "Hash" and then storing it in the database.
        public static string CreateSHA256(string str)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));

            var sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
