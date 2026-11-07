using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public class SvUser
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime expireDate { get; set; }

        public SvUser(string userName, string id, DateTime expiresDate)
        {
            _userName = userName;
            _id = id;
            expireDate = expiresDate;
        }
        public void GetExpire()
        {
            System.Console.WriteLine($"the expire date is: {expireDate}");
        }

        public void GetId()
        {
            System.Console.WriteLine($"de id user is: {Id}");
        }

        public void Getname()
        {
            System.Console.WriteLine($"the name user is: {UserName}");
        }
        
    }
}