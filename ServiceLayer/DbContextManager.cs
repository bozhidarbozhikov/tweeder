using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace ServiceLayer
{
    public class DbContextManager
    {
        private static TweeterContext _context;
        private static UserContext _userContext;
        private static CommentContext _commentContext;
        private static PostContext _postContext;

        //Tweeter contexts
        public static TweeterContext CreateContext()
        {
            _context = new TweeterContext();
            return _context;
        }

        public static TweeterContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }

        //UserContexts
        public static UserContext CreateUserContext(TweeterContext context)
        {
            _userContext = new UserContext(context);
            return _userContext;
        }

        public static UserContext GetUserContext()
        {
            return _userContext;
        }

        //CommentContexts
        public static CommentContext CreateCommentContext(TweeterContext context)
        {
            _commentContext = new CommentContext(context);
            return _commentContext;
        } 

        public static CommentContext GetCommentContext()
        {
            return _commentContext;
        }

        //PostContexts
        public static PostContext CreatePostContext(TweeterContext context)
        {
            _postContext = new PostContext(context);
            return _postContext;
        }
        public static PostContext GetPostContext()
        {
            return _postContext;
        }
    }
}
