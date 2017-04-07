using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    /// <summary>
    /// Dummy implementation to show how the system works
    /// </summary>
    class DummySearch : AbstractSearch
    {

        public override int search(int element){
            return new Random().Next(ary.Length);
        }
    }
}
