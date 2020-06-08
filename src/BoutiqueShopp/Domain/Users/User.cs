using System;

namespace Database
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string HashedPassword { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
