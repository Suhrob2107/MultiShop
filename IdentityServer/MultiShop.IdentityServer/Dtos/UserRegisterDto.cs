namespace MultiShop.IdentityServer.Dtos
{
    public class UserRegisterDto // Kullanıcı kayıt DTO'su
    {
        public string UserName { get; set; } = string.Empty; // Kullanıcı adı
        public string Email { get; set; } = string.Empty; // E-posta adresi
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
