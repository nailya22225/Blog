using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Database;
using WebApplication4.Models;

namespace WebApplication4.Infrastructure
{
    public static class MappingModels
    {
        public static Database.User MapModelUser(Models.User user)
        {
            return new Database.User() { Name = user.Name, LastName = user.LastName, City = user.City, Login = user.Login, Years = user.Years, Password = user.Password };
        }

        public static Models.User MapDatabaseUser(Database.User user)
        {
            return new Models.User() { Name = user.Name, LastName = user.LastName, City = user.City, Login = user.Login, Years = user.Years, Password = user.Password };
        }

        public static Database.Blog MapModelBlog(Models.Blog blog)
        {
            return new Database.Blog() { Text = blog.Text, Headline = blog.Headline, IsOpen=blog.IsOpen, UserId=blog.UserId };
        }

        public static Models.Blog MapDatabaseBlog(Database.Blog blog)
        {
            return new Models.Blog() { Id = blog.Id, Text = blog.Text, Headline = blog.Headline, IsOpen = blog.IsOpen, UserId = blog.UserId };
        }

        public static IEnumerable<Models.Blog> MapListDatabaseBlog(List<Database.Blog> blogs)
        {
            var mBlogs = new List<Models.Blog>();
            foreach (var blog in blogs)
                mBlogs.Add(MapDatabaseBlog(blog));
            return mBlogs;
        }
    }
}
