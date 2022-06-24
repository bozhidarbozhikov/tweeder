using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using BusinessLayer;

namespace BusinessLayer
{
    public class Comment
    {
        [Key]

        public int ID { get; private set; }

        [Required, MaxLength(280)]
        public string Contents { get; set; }

        [Required]
        public User Poster { get; set; }

        [MaxLength(20), ForeignKey("Poster")]
        public string PosterUsername { get; set; }

        [Required]
        public Post CommentedPost { get; set; }

        [Required, ForeignKey("CommentedPost")]
        public int CommentedPostID { get; set; }

        public Comment(string contents, User poster, Post commentedPost)
        {
            this.Contents = contents;
            this.Poster = poster;
            this.PosterUsername = poster.Username;
            this.CommentedPost = commentedPost;
            this.CommentedPostID = commentedPost.ID;
        }
        private Comment()
        {

        }
    }
}
