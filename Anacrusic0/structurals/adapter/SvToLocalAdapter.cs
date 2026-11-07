using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public class SvToLocalAdapter : User
    {
        public SvToLocalAdapter(SvUser adaptated)
        {
            this.name = adaptated.UserName;
            this.UuId = adaptated.Id;
            this.expiresOn = adaptated.expireDate;
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