using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public class LocalUser : User
    {
        public LocalUser(string userName, string Id, DateTime fecha)
        {
            this.name = userName;
            this.UuId = Id;
            this.expiresOn = fecha;
        }
        public override void GetExpire()
        {
            System.Console.WriteLine($"the expire date is: {this.expiresOn}");
        }

        public override void GetId()
        {
            System.Console.WriteLine($"de id user is: {this.UuId}");
        }

        public override void Getname()
        {
            System.Console.WriteLine($"the name user is: {name}");
        }
    }
}