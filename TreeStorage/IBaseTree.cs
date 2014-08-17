using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStorage
{
    public interface IBaseTree<T> : IEnumerable<T>, ICloneable
    {
        T Data { get; set; }
        IBaseTree<T> Parent { get; }

        /// <summary>
        /// find all nodes which will suit comparison condition
        /// </summary>
        /// <param name="c">comparison conditions</param>
        /// <returns>list of handles</returns>        
        IList<IBaseTree<T>> Find(Comparison<T> c);
        
        /// <summary>
        /// returns list of all direct children
        /// </summary>
        /// <returns>list of subtrees</returns>
        IList<IBaseTree<T>> GetDirectChildren();
    }
}
