using System;
using System.Collections.Generic;
using Abstract;

namespace TreeStorage
{
    public class BinaryTree<T> : BaseTree<T>, IBinaryTree<T>
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

        public T LeftData { set; private get; }
        public T RightData { set; private get; }
        public IBinaryTree<T> Left { get; private set; }
        public IBinaryTree<T> Right { get; private set; }
    }
}