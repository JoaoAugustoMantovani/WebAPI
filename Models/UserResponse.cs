namespace WebAPI.Models
{
    public record UserResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public UserResponse(string name, string email, int idade)
        {
            Name = name;
            Email = email;
            Idade = idade;
        }
    }
}