using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace ServiceLayer
{
    public class CommentManager : IManager<Comment, int>
    {
        private CommentContext _context;

        public CommentManager(TweeterContext context)
        {
            this._context = new CommentContext(context);
        }

        public void Create(Comment item)
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

        public Comment Read(int key, bool useNavigationProperties = true)
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

        public IEnumerable<Comment> ReadAll(bool useNavigationProperties = true)
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

        public void Update(Comment item, bool useNavigationProperties = true)
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
