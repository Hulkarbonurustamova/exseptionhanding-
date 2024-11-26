using System;

namespace ConsoleApp1
{
    internal class Program
    {
      
       

        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            try
            {
               
                UserProfile user = new UserProfile();
                user.Username = username;
                user.Password = password;

              
                ValidateUser(user); 

           
                Console.Clear();
                Console.WriteLine("Welcome to the system...");
            }
            catch (InvalidUserCredentialsException ex)
            {
              
                Console.Clear();
                Logger.LogError(InvalidUserCredentialsException.CODE, ex.Message);  
            }
            finally
            {
                Console.WriteLine("Session finished.");
            }
        }

    
        public static void ValidateUser(UserProfile user)
        {
            string correctUsername = "Hulkar";  
            string correctPassword = "password123";  

            
            if (user.Username != correctUsername && user.Password != correctPassword)
            {
                throw new InvalidUserCredentialsException();
            }
        }

        

        
        
    }
}
