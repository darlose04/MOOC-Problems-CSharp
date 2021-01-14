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
        private int _sum { get; set; }
        public int Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
            }
        }

        public Statistics()
        {
            _count = 0;
            _sum = 0;
        }

        public void AddNumber(int number)
        {
            this._sum += number;
            this._count++;
        }

        public double Average()
        {
            double sum = _sum;
            double average = sum / _count;
            return average;
        }
    }
}
