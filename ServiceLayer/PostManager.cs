using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class PostManager : IManager<Post, int>
    {
        private PostContext _context;

        public PostManager(TweeterContext context)
        {
            this._context = new PostContext(context);
        }
        public void Create(Post item)
        {
            try
            {
                _context.Create(item);
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
                _context.Delete(key);
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
                return _context.Read(key, useNavigationProperties);
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
                return _context.ReadAll(useNavigationProperties);
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
                _context.Update(item, useNavigationProperties);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
