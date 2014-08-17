using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStorage
{
    public class Tree<T> : BaseTree<T>, ITree<T>
    {
        public override IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override T Data { get; set; }

        public override IBaseTree<T> Parent
        {
            get { throw new NotImplementedException(); }
        }

        public override IList<IBaseTree<T>> Find(Comparison<T> c)
        {
            throw new NotImplementedException();
        }

        public override IList<IBaseTree<T>> GetDirectChildren()
        {
            throw new NotImplementedException();
        }

        public ITree<T> AddChild(T data)
        {
            throw new NotImplementedException();
        }

        public bool RemoveChild(ITree<T> t)
        {
            throw new NotImplementedException();
        }
    }
}
