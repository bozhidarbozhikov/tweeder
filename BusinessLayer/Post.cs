using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public class Post
    {
        [Key]
        public int ID { get; private set; }

        [Required, MaxLength(280)]
        public string Contents { get; set; }

        [Required]
        public User Poster { get; set; }

        [Required, ForeignKey("Poster")]
        public string PosterUsername { get; set; }

        public List<Comment> Comments { get; set; }

        public Post(string _contents, User _poster)
        {
            this.Contents = _contents;
            this.Poster = _poster;
            this.PosterUsername = _poster.Username;
        }

        private Post()
        {

        }
    }
}
