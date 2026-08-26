using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        public int Idade { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdatedAt { get; set; }

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