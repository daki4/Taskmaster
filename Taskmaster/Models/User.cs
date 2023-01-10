﻿namespace Taskmaster.Models
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
