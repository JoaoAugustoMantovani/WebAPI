using System.ComponentModel.DataAnnotations;

public record class UserDTO
{
    
    public string Email { get; set;}
    
    
    public string Name { get; set;}
    
    
    public string Senha { get; set; }

    public int Idade { get; set;}

    public UserDTO(string email, string name, int idade, string senha)
    {
        Email = email;
        Name = name;
        Senha = senha;
        Idade = idade;

    }

}