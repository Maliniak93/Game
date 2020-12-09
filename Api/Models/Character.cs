namespace Api.Models
{
    public class Character
    {
        // Main info about character
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Nickname { get; set; }
        public User User { get; set; }
        
        // Character statistic
        public int Level { get; set; }
        public int Experience { get; set; }
        public int FullHealth { get; set; }
        public int FullMana { get; set; }
        public int Cp { get; set; }
    }
}