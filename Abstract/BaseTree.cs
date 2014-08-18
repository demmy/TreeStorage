using System;
using System.Collections;
using System.Collections.Generic;

namespace Abstract
{
    public abstract class BaseTree<T> : IBaseTree<T>
    {
        public abstract IEnumerator<T> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public abstract object Clone();
        public abstract T Data { get; set; }
        public abstract IBaseTree<T> Parent { get; }
        public abstract IList<IBaseTree<T>> Find(Comparison<T> c);
        public abstract IList<IBaseTree<T>> GetDirectChildren();
    }
}