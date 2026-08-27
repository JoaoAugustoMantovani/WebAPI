using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WebAPI.Models
{

    public class User
    {
        [Key]
        public Guid Id { get; private set; }

        public string Email { get; private set; }

        public string Name { get; private set; }

        public string Senha { get; private set; }

        public int Idade { get; private set; }
        public DateTime CreationDate { private get; set; }
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
            if (string.IsNullOrWhiteSpace(senha))
            {
                throw new Exception("Senha não pode estar vazia");
            }


            return new User(email, name, idade, senha);
        }

    }
}