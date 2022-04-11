namespace CustomJWTAuthorization.Models
{
    public class PasswordModel
    {
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
