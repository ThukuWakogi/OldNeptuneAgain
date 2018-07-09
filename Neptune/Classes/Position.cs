using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    public sealed class Position
    {
        public int Id { get; set; }

        private string _position;
        public string PositionName
        {
            get => _position;
            set => _position = value ?? throw new ArgumentException(nameof(PositionName) + " cannot be null");
        }

        public decimal Salary { get; set; }
    }
}
