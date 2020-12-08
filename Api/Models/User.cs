using System.Collections.Generic;

namespace Api.Models
{
    public class User
    
    {
        //General

        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        // Characters

        public ICollection<Character> Characters { get; set; }
    }
}