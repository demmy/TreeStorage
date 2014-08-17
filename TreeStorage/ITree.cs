using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStorage
{
    public interface ITree<T> : IBaseTree<T>
    {
        /// <summary>
        /// adds child
        /// </summary>
        /// <param name="data">data to add in child</param>
        /// <returns>new child reference</returns>
        ITree<T> AddChild(T data);

        /// <summary>
        /// returns true on successfull removal or false if @t is null or not direct child
        /// </summary>
        /// <param name="t">subtree to remove</param>
        /// <returns>status</returns>
        bool RemoveChild(ITree<T> t);
    }
}
