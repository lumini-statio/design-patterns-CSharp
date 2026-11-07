using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace adapter
{
    public class Minecraft
    {
        private Dictionary<string,User>? users = new();

        public void AddUser(User user)
        {
            users.Add(user.UuId,user);
        }
        public void GetUsers()
        {
            foreach (var user in users)
            {
                user.Value.Getname();
                user.Value.GetId();
                user.Value.GetExpire();
            }
        }
    }
}