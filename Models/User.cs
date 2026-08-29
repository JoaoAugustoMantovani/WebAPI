using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class User
    {
        public User() {}

        public User(string email, string name, string senha, int idade)
        {
            Id = Guid.NewGuid();
            Email = email;
            Name = name;
            Senha = senha;
            Idade = idade;
            CreationDate = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; private set; }

        [Required]
        public string Email { get; private set; }

        [Required]
        public string Name { get; private set; }

        [Required]
        public string Senha { get; private set; }

        public int Idade { get; private set; }

        public DateTime CreationDate { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        private User(string email, string name, int idade, string senha)
        {
            Id = Guid.NewGuid();
            Email = email;
            Name = name;
            Senha = senha;
            Idade = idade;
            CreationDate = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public static User CreateUser(string email, string name, int idade, string senha)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email não pode estar vazio");

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Nome não pode estar vazio");

            if (string.IsNullOrWhiteSpace(idade.ToString()))
                throw new Exception("Idade não pode estar vazio");

            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Senha não pode estar vazia");

            return new User(email, name, idade, senha);
        }

        public User UpdateUser(string email, string name, int idade, string senha)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email não pode estar vazio");

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Nome não pode estar vazio");

            if (string.IsNullOrWhiteSpace(idade.ToString()))
                throw new Exception("Idade não pode estar vazio");

            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Senha não pode estar vazia");

            SetEmail(email);
            SetName(name);
            SetSenha(senha);
            SetIdade(idade);

            return this;
        }

        public void SetEmail(string email) => Email = email;

        public void SetName(string name) => Name = name;

        public void SetIdade(int idade) => Idade = idade;

        public void SetSenha(string senha) => Senha = senha;
    }
}