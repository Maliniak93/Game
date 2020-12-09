namespace Api.Models
{
    public class Monster
    {
        // Main Info about Monster
        public int Id { get; set; }
        public string MonsterName { get; set; }

        // Monster Statistic
        public int FullHealth { get; set; }
        public int Cp { get; set; } 
    }
}