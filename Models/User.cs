using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    
    public class User
    {
        [Key]
        public Guid Id { get; private set; }
        [Required]
        public string Email { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public int Idade { get; private set; }
        public DateTime CreationDate { private get; set; }
        public DateTime UpdatedAt { get; private set; }

        public User(string email, string name, int idade)
        {
            Id = Guid.NewGuid();
            Email = email;
            Name = name;
            Idade = idade;
            CreationDate = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}