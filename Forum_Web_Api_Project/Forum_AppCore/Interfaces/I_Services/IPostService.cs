using Domain_Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore_Forum.Interfaces.I_Services
{
    public interface IPostService
    {
        Post GetById(int id);

        IEnumerable<Post> GetAllPosts();

        Post Create(Post data);
        Post Update(Post data);
        Post Delete(int id);

    }
}
