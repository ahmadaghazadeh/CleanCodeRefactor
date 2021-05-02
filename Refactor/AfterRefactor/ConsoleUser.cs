using System;

namespace Refactor
{
   public class ConsoleUser
    {
        public static UserDto GetUser()
        {
            string userName = ConsleReadLine("enter userName:");
            string firstName = ConsleReadLine("enter firstName:");
            string LastName = ConsleReadLine("enter LastName:");
            string password = ConsleReadLine("enter Password:");
            UserDto user = new UserDto(userName, firstName, LastName, password);
            return user;
        }

        private static string ConsleReadLine(string Prompt)
        {
            Console.WriteLine(Prompt);
            return Console.ReadLine();
        }
    }
}
