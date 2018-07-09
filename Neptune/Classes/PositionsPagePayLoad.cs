using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    class PositionsPagePayLoad
    {
        private ObservableCollection<Position> _positions = new ObservableCollection<Position>();

        public ObservableCollection<Position> Positions
        {
            get => _positions;
            set { if (_positions != value) _positions = value; }
        }

        public PositionsPagePayLoad(ObservableCollection<Position> incomingPositions)
        {
            _positions = incomingPositions;
        }
    }
}
