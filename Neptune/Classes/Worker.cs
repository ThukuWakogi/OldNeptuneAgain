using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    public sealed class Worker : Person
    {
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get => _PhoneNumber;
            set => _PhoneNumber = value ?? throw new ArgumentException(nameof(PhoneNumber) + "cannot be null");
        }

        private Position _position;
        public Position Position
        {
            get => _position;
            set => _position = value ?? throw new ArgumentException(nameof(Position) + "cannot be null");
        }
    }
}
