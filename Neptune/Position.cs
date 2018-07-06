using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    public sealed class Position
    {
        private int _id;
        public int ID
        {
            get => _id;
            set => _id = value;
        }

        private string _position;
        public string PositionName
        {
            get => _position;
            set => _position = value ?? throw new ArgumentException(nameof(PositionName) + " cannot be null");
        }

        private decimal _salary;
        public decimal Salary
        {
            get => _salary;
            set => _salary = value;
        }
    }
}
