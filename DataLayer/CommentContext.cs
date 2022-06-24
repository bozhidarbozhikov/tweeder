using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class CommentContext : ICRUD<Comment, int>
    {
        private TweeterContext _context;

        public CommentContext(TweeterContext context)
        {
            this._context = context;

        }
        public void Create(Comment comment)
        {
            try
            {

                User posterFromDB = _context.Users.Find(comment.PosterUsername);

                if (posterFromDB != null)
                {
                    comment.Poster = posterFromDB;
                }

                Post postFromDB = _context.Posts.Find(comment.CommentedPostID);

                if (postFromDB != null)
                {
                    comment.CommentedPost = postFromDB;
                }

                _context.Comments.Add(comment);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Comment commentFromDb = Read(key);

                _context.Comments.Remove(commentFromDb);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Comment Read(int key, bool useNavigationProperties = false)
        {
            try
            {
                return _context.Comments.Find(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<Comment> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                return _context.Comments.ToList();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Comment comment, bool useNavigationProperties = false)
        {
            try
            {
                Comment commentFromDb = Read(comment.ID);

                _context.Entry(commentFromDb).CurrentValues.SetValues(comment);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
