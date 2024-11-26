using System;
 public class InvalidUserCredentialsException : Exception
        {
            public static string CODE = "invalid_user_credentials";

            public InvalidUserCredentialsException()
                : base("Username or password is incorrect")
            {
            }

            public override string ToString()
            {
                return $"{CODE}: {Message}";
            }
        }

