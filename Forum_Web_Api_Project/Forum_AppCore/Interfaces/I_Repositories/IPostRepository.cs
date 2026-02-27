using Domain_Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore_Forum.Interfaces.I_Repositories
{
    public interface IPostRepository
    {
        Post GetById(int id);

        IEnumerable<Post> GetAllCommentByPost();
        Post Create(Post data);
        Post Update(Post data);


    }
}
