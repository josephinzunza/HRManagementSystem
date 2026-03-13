namespace HRManagementSystem.Models
{
    public class User
    {
        public uint Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = [];
    }
}
