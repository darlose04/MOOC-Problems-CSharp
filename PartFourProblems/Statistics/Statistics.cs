using System;

namespace Statistics
{
    public class Statistics
    {
        private int _count { get; set; }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public Statistics()
        {
            this._count = 0;
        }

        public void AddNumber(int number)
        {
            this._count++;
        }
    }
}
