using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCommon.Factoring
{
    public class FactorEnumerator : IEnumerable<long>
    {
        private long _numberToFactor;
        private List<long> _laterSeries;

        public FactorEnumerator(long numberToFactor)
        {
            _numberToFactor = numberToFactor;
            _laterSeries = new List<long>();
        }

        public IEnumerator<long> GetEnumerator()
        {
            List<long> returnedFactors = new List<long>();
            for (long i = 1; i < _numberToFactor / 2; i++)
            {
                if (_numberToFactor % i == 0)
                {
                    if (_laterSeries.Count > 1 && _laterSeries.Min() <= i)
                    {
                        break;
                    }
                    else
                    {
                        _laterSeries.Add(_numberToFactor / i);
                        if(!returnedFactors.Contains(i))
                        {
                            returnedFactors.Add(i);
                            yield return i;
                        }
                        
                    }
                }
            }

            foreach (long highNum in _laterSeries.OrderBy(num => num))
            {
                if (!returnedFactors.Contains(highNum))
                {
                    returnedFactors.Add(highNum);
                    yield return highNum;
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
