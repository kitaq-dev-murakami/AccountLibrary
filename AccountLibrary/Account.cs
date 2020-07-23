using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class Account
    {
        public Account()
        {

        }

        public void Create(string id, string password)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException(id);
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException(password);
            }
        }
    }
}
