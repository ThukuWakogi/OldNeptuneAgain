using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    class PositionsPagePayLoad : INotifyPropertyChanged
    {
        private List<Position> _positions = new List<Position>();
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Position> Positions
        {
            get => _positions;
            set
            {
                if (_positions != value)
                {
                    _positions = value;
                    OnPropertyChanged(nameof(Positions));
                }
            }
        }

        public PositionsPagePayLoad(List<Position> incomingPositions)
        {
            _positions = incomingPositions;
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) => PropertyChanged?.Invoke(this, args);
        private void OnPropertyChanged(string propertyName) => this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
    }
}
