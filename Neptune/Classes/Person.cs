using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    public abstract class Person : Object
    {
        protected string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value ?? throw new ArgumentException(nameof(FirstName) + "cannot be null");
        }

        protected string _lastName;
        public string LastName
        {
            get => _lastName;
            set => _lastName = value ?? throw new ArgumentException(nameof(FirstName) + "cannot be null");
        }
    }
}
