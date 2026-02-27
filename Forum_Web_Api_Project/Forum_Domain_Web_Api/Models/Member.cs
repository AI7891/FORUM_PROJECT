using Domain_Forum.Enums;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Domain_Forum.Models
{
    public class Member
    {
        public int Id { get; private set; }
        public string? Username { get; private set; }
        public string? Password { get; private set; }
        public string Email { get; private set; } = default!;
        public MemberRole Role { get; private set; }

        // Maybe needed for future use (?):
        //public List<Post> Posts { get; private set; } = new List<Post>();
        //public List<Comment> Comments { get; private set; } = new List<Comment>();

        // Constructors
        // - Empty for EFC
        public Member() { }

        // - For creating a new member
        public Member(string username, string password, string email, MemberRole role)
        {
            if (string.IsNullOrWhiteSpace(email) || !MailAddress.TryCreate(email, out _))
                throw new ArgumentException("L'e-mail est invalide", nameof(email));

            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Le nom d'utilisateur ne peut pas être vide", nameof(username));

            Username = username;
            Password = password;
            Email = email;
            Role = MemberRole.User;
        }

        // - For recup of an existing member (from database)
        public Member(int id, string username, string password, string email, MemberRole role)
            : this(username, password, email, role)
        {
            Id = id;
        }

    }
}
