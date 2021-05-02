using Refactor.Framework;
using System.IO;

namespace Refactor
{
    public class PersistanceUserFile : IPersistanceUser
    {
        public void Save(User user)
        {
            File.WriteAllText("", $"{user.UserName},{user.FirstName},{user.LastName},{user.Password}");
        }
    }
}
