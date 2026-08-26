public record class UserDTO
{
    public string Email { get; set;}
    public string Name { get; set;}
    public int Idade { get; set;}

    public UserDTO(string email, string name, int idade)
    {
        Email = email;
        Name = name;
        Idade = idade;

    }

}