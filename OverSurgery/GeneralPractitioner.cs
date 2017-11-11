using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class GeneralPractitioner
    {
        string name;
        int status;
        DateTime dateJoined;
        string loginName;
        string password;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public DateTime DateJoined
        {
            get
            {
                return dateJoined;
            }

            set
            {
                dateJoined = value;
            }
        }

        public string LoginName
        {
            get
            {
                return loginName;
            }

            set
            {
                loginName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
