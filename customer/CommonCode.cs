using System;
using System.Collections.Generic;
using System.Text;

namespace customer
{
    public class CommonCode
    {
        public bool namevalidation(String Name)
        {
            if(Name.Length==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
