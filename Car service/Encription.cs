using System.Security.Cryptography;

namespace Car_service
{
    class Encription
    {
        public static string EncriptionString(string str)
        {
            string encription = "";
            using (var hash = SHA256.Create())
            {
                byte[] bhash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
                for (int i = 0; i < bhash.Length; i++)
                {
                    encription += bhash[i].ToString("X2");
                }
            }
            return encription;

        }
    }
}
