using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper
{
    internal class DoubleEqualityComparer : IEqualityComparer<double>
    {
        public bool Equals(double x, double y)
        {
            return (x - y) < 0.0000000001;
        }

        public int GetHashCode([DisallowNull] double obj)
        {
            throw new NotImplementedException();
        }
    }
}
