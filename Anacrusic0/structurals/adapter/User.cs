using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public abstract class User
    {
        public string? name { get; set; }
        public string? UuId { get; set; }
        public DateTime expiresOn { get; set; }
        public abstract void Getname();
        public abstract void GetId();
        public abstract void GetExpire();
    }
}