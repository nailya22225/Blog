using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Database;

namespace WebApplication4.Infrastructure
{
    public static class DbConnection
    {
        public static void Delete()
        {
            using (var db = new BlogContext())
            {
                foreach (var user in db.Users)
                    db.Remove(user);

                foreach (var user in db.Blogs)
                    db.Remove(user);
                db.SaveChanges();
            }
        }
        public static bool IsHasUser(string email, string password)
        {
            using (var db = new BlogContext())
            {
                var isLogin = db.Users.FirstOrDefault(u =>
                u.Login == email && u.Password == password);
                return isLogin != null;
            }
        }

        public static int GetId(string email, string password)
        {
            using (var db = new BlogContext())
            {
                var isLogin = db.Users.FirstOrDefault(u =>
                u.Login == email && u.Password == password);
                return isLogin.Id;
            }
        }

        public static void SaveUser(User user)
        {
            using (var db = new BlogContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public static List<Blog> DisplayBlog(String id)
        {
            using (var db = new BlogContext())
            {
                var blogs = db.Blogs.Where(b=>b.UserId.ToString().Equals(id)).ToList();
                return blogs;
            }
        }

        public static void EditBlog(Blog blog)
        {
            using (var db = new BlogContext())
            {
                var blogs = db.Blogs.FirstOrDefault(b => b.Id==blog.Id);
                blogs.Headline = blog.Headline;
                blogs.IsOpen = blog.IsOpen;
                blogs.Text = blog.Text;
                db.SaveChanges();
            }
        }

        public static List<Blog> DisplayAllBlogs()
        {
            using (var db = new BlogContext())
            {
                var blogs = db.Blogs.Where(b => b.IsOpen == true);
                return blogs.ToList();
            }
        }

        public static void SaveBlog(Blog blog)
        {
            using (var db = new BlogContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }

        public static User GetUser(string id)
        {
            using (var db = new BlogContext())
            {
                var user = db.Users.FirstOrDefault(u =>
                u.Id.ToString().Equals(id));
                return user;
            }
        }
    }
}
