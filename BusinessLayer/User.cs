using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public class User
    {
        [Key, MaxLength(20)]
        public string Username { get; private set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; private set; }

        [Required]
        public string Country { get; set; }

        [Required, Range(13, 100)]
        public int Age { get; set; }

        public IEnumerable<Post> Posts { get; set; }

        public User(string username, string name, string email, string password, string country, int age)
        {
            this.Username = username;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Country = country;
            this.Age = age;
        }

        public User(string username, string name, string email, string password, string country, int age, IEnumerable<Post> posts) 
            : this(username, name, email, password, country, age)
        {
            this.Posts = posts;
        }

        private User()
        {

        }
    }
}
