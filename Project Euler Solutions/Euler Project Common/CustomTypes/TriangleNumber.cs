using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCommon.CustomTypes
{
    public class TriangleNumber
    {
        private long _sequenceIndex;
        public long SequenceIndex
        {
            get
            {
                return _sequenceIndex;
            }
        }

        public long Value
        {
            get
            {
                int sum = 0;
                for(int i = 1; i <= _sequenceIndex; i++)
                {
                    sum = sum + i;
                }
                return sum;
            }
        }

        public TriangleNumber(long sequenceIndex)
        {
            _sequenceIndex = sequenceIndex;
        }
    }
}
