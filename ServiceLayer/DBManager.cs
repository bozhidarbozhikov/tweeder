using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace ServiceLayer
{
    public class DBManager<T, K>
    {
        public ICRUD<T, K> context;

        public DBManager(ICRUD<T, K> context)
        {
            this.context = context;
        }

        public void Create(T item)
        {
            try
            {
                context.Create(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public T Read(K key, bool useNavigationProperties = true)
        {
            try
            {
                return context.Read(key, useNavigationProperties);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<T> ReadAll(bool useNavigationProperties = true)
        {
            try
            {
                return context.ReadAll(useNavigationProperties);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(T item, bool useNavigationProperties = true)
        {
            try
            {
                context.Update(item, useNavigationProperties);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(K key)
        {
            try
            {
                context.Delete(key);
            }
            catch (Exception e)
            {
                throw  e;
            }
        }
    }
}
