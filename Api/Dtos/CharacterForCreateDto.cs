namespace Api.Dtos
{
    public class CharacterForCreateDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        
        public int UserId { get; set; }
    }
}