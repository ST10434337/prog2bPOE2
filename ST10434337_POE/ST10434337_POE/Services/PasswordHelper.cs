namespace ST10434337_POE.Services
{
    public class PasswordHelper
    {
        // Have all BCrypt code in one place
        public string HashPassword (string password)
        {
            // 13 is workfactor
            return BCrypt.Net.BCrypt.EnhancedHashPassword (password, 13);
        }
        public bool VerifyPassword (string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password,passwordHash);
        }
    }
}
