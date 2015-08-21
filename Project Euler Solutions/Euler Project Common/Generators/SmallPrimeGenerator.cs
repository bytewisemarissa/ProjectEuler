using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCommon.Generators
{
    //uses unoptimized Sieve of Eratosthenes
    //https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
    public class SmallPrimeGenerator : IEnumerable<int>
    {
        private bool[] _sieve;
        private int _lastPrimeIndex = 0, _limit;

        public SmallPrimeGenerator(int limit)
        {
            _limit = limit;
            _sieve = new bool[_limit];
            for (int i = 0; i < _limit; i++)
            {
                _sieve[i] = true;
            }

            _sieve[0] = false;
            _sieve[1] = false;
        }

        private void FindNextPrimeInSieve()
        {
            for (int i = _lastPrimeIndex; i < _limit; i++)
            {
                if (_sieve[i])
                {
                    _lastPrimeIndex = i;
                    break;
                }
            }
        }

        private void UpdateSieve()
        {
            for (int i = _lastPrimeIndex; i < _limit; i++)
            {
                if (_sieve[i])//check if number is marked prime
                {
                    if (i % _lastPrimeIndex == 0)//if marked prime check modulo of new prime
                    {
                        _sieve[i] = false;//mark composite
                    }
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            while (true)
            {
                int testForComplete = _lastPrimeIndex;

                FindNextPrimeInSieve();

                if (testForComplete == _lastPrimeIndex)
                {
                    break;
                }

                UpdateSieve();

                yield return _lastPrimeIndex;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
