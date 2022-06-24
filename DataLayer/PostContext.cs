using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class PostContext : ICRUD<Post, int>
    {
        private TweeterContext _context;

        public PostContext(TweeterContext context)
        {
            this._context = context;
        }

        public void Create(Post post)
        {
            try
            {
                User posterFromDB = _context.Users.Find(post.PosterUsername);

                if (posterFromDB != null)
                {
                    post.Poster = posterFromDB;
                }

                List<Comment> comments = new List<Comment>();

                if (post.Comments != null)
                {
                    foreach (var comment in post.Comments)
                    {
                        Comment commentFromDB = _context.Comments.Find(comment.ID);

                        if (commentFromDB != null)
                        {
                            comments.Add(commentFromDB);
                        }
                        else
                        {
                            comments.Add(comment);
                        }
                    }
                }

                post.Comments = comments;

                _context.Posts.Add(post);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Post postFromDb = Read(key);

                _context.Posts.Remove(postFromDb);
                _context.SaveChanges();

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Post Read(int key, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Post> query = _context.Posts.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    query = query.Include(b => b.Poster).Include(b => b.Comments);
                }

                return query.SingleOrDefault(b => b.ID == key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<Post> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Post> query = _context.Posts.AsNoTracking();

                if (useNavigationProperties)
                {
                    query = query.Include(b => b.Poster).Include(b => b.Comments);
                }

                return query.ToList();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Post item, bool useNavigationProperties = false)
        {
            try
            {
                Post postFromDb = Read(item.ID);

                if (useNavigationProperties)
                {
                    postFromDb.Poster = item.Poster;

                    List<Comment> comments = new List<Comment>();

                    foreach (Comment comment in item.Comments)
                    {
                        Comment commentFromDB = _context.Comments.Find(comment.ID);

                        if (commentFromDB != null)
                        {
                            comments.Add(commentFromDB);
                        }
                        else
                        {
                            comments.Add(comment);
                        }
                    }

                    postFromDb.Comments = comments;
                }

                _context.Entry(postFromDb).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
