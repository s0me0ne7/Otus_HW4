using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_HW4.IO
{
    public interface ISecretValue
    {
        public int GetSecretValue(int startOfRange, int endOfRange);

    }
}
