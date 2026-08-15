using System;
using System.Text;
using System.Security.Cryptography;

namespace GymManagementSystemBLLayer.Common
{
    public class PasswordHelperBLL
    {
        private const int HashSize = 32;
        private const int Iterations = 10000;

        // ==========================================
        // FIXED SALT
        // Same password = Same hash
        // ==========================================
        private const string FixedSalt =
            "GymManagementSystem@2026#Salt";


        // ==========================================
        // HASH PASSWORD - REGISTRATION
        // ==========================================
        public static string HashPassword(string password)
        {
            byte[] salt =
                Encoding.UTF8.GetBytes(FixedSalt);

            using (Rfc2898DeriveBytes pbkdf2 =
                new Rfc2898DeriveBytes(
                    password,
                    salt,
                    Iterations))
            {
                byte[] hash =
                    pbkdf2.GetBytes(HashSize);

                return Convert.ToBase64String(hash);
            }
        }
    }
}