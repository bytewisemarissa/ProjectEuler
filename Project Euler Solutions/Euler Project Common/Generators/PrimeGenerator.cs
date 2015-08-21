using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCommon.Generators
{
    public class PrimeGenerator : IEnumerable<long>
    {
        long _limit;
        long _currentSequence;

        public PrimeGenerator(long limit)
        {
            _limit = limit;


        }

        public IEnumerator<long> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
