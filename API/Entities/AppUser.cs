namespace API.Entities {
    public class AppUser {
        public int Id { set; get; }
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}