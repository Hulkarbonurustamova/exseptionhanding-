using System;
public static class Logger
        {
            
            public static void LogError(string code, string message)
            {
                string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine($"[{currentTime}] ERR | Code: {code} | Message: {message}");
            }
        }