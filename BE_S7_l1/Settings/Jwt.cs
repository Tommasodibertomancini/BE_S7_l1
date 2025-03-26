namespace BE_S7_l1.Settings
{
    public class Jwt
    {
        public required string Securitykey { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
        public required int ExpiresInMinutes { get; set; }

    }
}
