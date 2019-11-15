using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    class Details
    {
        public String username;
        public String password;
        public String sample;
 
        public void InvalidUser1()
        {
            username = "Test1";
            password = "Test2";

        }

        public void InvalidUser2()
        {
            username = "Test";
            password = "admin@123";
        }
        public void InvalidUser3()
        {
            username = "Admin";
            password = "Test123";
        }

        public void ValidUser()
        {
            username = "Admin";
            password = "admin123";
        }

    }
}
