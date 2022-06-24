using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class UserManager : IManager<User, string>
    {
        public UserContext _userContext;

        public UserManager(TweeterContext context)
        {
            this._userContext = new UserContext(context);
        }

        public void Create(User item)
        {
            try
            {
                _userContext.Create(item);
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
                _userContext.Delete(key);
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
                return _userContext.Read(key, useNavigationProperties);
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
                return _userContext.ReadAll(useNavigationProperties);
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
                _userContext.Update(item, useNavigationProperties);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
