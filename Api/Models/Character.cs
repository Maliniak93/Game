namespace Api.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public int Cp { get; set; } //Combat Power
        public User User { get; set; }
        public int UserId { get; set; }
    }
}