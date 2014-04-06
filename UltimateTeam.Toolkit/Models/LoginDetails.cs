﻿using UltimateTeam.Toolkit.Extensions;

namespace UltimateTeam.Toolkit.Models
{
    public class LoginDetails
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string SecretAnswer { get; set; }

        public Platform Platform { get; set; }

        public LoginDetails(string username, string password, string secretAnswer, Platform platform)
        {
            username.ThrowIfInvalidArgument();
            password.ThrowIfInvalidArgument();
            secretAnswer.ThrowIfInvalidArgument();
            Username = username;
            Password = password;
            SecretAnswer = secretAnswer;
            Platform = platform;
        }

        public LoginDetails()
        {
        }
    }
}