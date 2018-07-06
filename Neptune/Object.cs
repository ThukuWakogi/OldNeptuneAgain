using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    public abstract class Object
    {
        protected int _id;
        public int ID
        {
            get => _id;
            set => _id = value;
        }

        protected DateTime _dateAdded;
        public DateTime DateAdded
        {
            get => _dateAdded;
            set => _dateAdded = value;
        }

        protected Worker _addedBy;
        public Worker AddedBy
        {
            get => _addedBy;
            set => _addedBy = value ?? throw new ArgumentException(nameof(AddedBy) + "cannot be null");
        }

        protected DateTime _dateLastUpdated;
        public DateTime DateLastUpdated
        {
            get => _dateLastUpdated;
            set => _dateLastUpdated = value;
        }

        protected Worker _lastUpdatedBy;
        public Worker LastUpdatedBy
        {
            get => _lastUpdatedBy;
            set => _lastUpdatedBy = value ?? throw new ArgumentException(nameof(AddedBy) + "cannot be null");
        }
    }
}
