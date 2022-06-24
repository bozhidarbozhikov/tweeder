using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class UserContext : ICRUD<User, string>
    {
        private TweeterContext _context;

        public UserContext(TweeterContext context)
        {
            this._context = context;
        }

        public void Create(User user)
        {
            try
            {
                List<Post> posts = new List<Post>();

                if (user.Posts != null)
                {
                    foreach (Post post in user.Posts)
                    {
                        Post postFromDB = _context.Posts.Find(post.ID);

                        if (postFromDB != null) posts.Add(postFromDB);
                        else posts.Add(post);
                    }
                }

                user.Posts = posts;

                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(string key)
        {
            try
            {
                User userFromDb = Read(key);

                _context.Users.Remove(userFromDb);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public User Read(string key, bool useNavigationProperties = false)
        {
            try
            {
                return _context.Users.Find(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<User> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(User item, bool useNavigationProperties = false)
        {
            try
            {
                User userFromDb = Read(item.Username);

                _context.Entry(userFromDb).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
