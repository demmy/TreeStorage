using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStorage
{
    public interface IBinaryTree<T> : IBaseTree<T>
    {
        T LeftData { set; }
        T RightData { set; }
        IBinaryTree<T> Left { get; }
        IBinaryTree<T> Right { get; }
    }
}
