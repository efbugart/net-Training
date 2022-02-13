using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahaJsonParse
{
    public class PersonNameComparer : IEqualityComparer<MyObject>
    {
        public bool Equals(MyObject x, MyObject y)
        {
            return x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode([DisallowNull] MyObject obj)
        {
            return obj.Email.GetHashCode() ^ (obj.FirstName == null ? 0 : obj.FirstName.GetHashCode()) ^ (obj.LastName == null ? 0 : obj.LastName.GetHashCode());
        }
    }
}
