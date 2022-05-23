using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using IT_ORG_SQLite_RGR_2022.Services.Interfaces;

namespace IT_ORG_SQLite_RGR_2022.Services
{
    /// <summary>
    /// Класс реализует хеширование (шифрование SHA256)
    /// </summary>
    public class EncryptionService : IEncryptionService
    {
        public string ComputeSha256Hash(string s)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(s));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void Dispose()
        {
        }
    }
}
