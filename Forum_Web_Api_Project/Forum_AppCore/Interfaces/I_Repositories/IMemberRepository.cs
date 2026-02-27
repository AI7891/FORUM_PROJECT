using Domain_Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStructure_Forum_DB.Repositories
{
   public interface IMemberRepository
    {
        Member? GetById(int id);
        Member Insert(Member data);
        string? GetHashPwd(string email);
        Member GetByEmail(string email);
    }
}
