using System;
using System.Collections.Generic;
using Abstract;

namespace TreeStorage
{
    public class Tree<T> : BaseTree<T>, ITree<T>
    {
        private T data;
        private Tree<T> head;
        private Tree<T> next;

        private Tree(T data, Tree<T> head, Tree<T> next)
        {
            this.data = data;
            this.head = head;
            this.next = next;
        }

        public Tree() : this(default(T), null, null)
        {
        }

        public override IEnumerator<T> GetEnumerator()
        {
            Tree<T> current = this;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        public override object Clone()
        {
            return new Tree<T>(data, head, next);
        }

        public override T Data
        {
            get { return data; }
            set { data = value; }
        }

        public override IBaseTree<T> Parent
        {
            get { return head; }
        }

        public override IList<IBaseTree<T>> Find(Comparison<T> c)
        {
            throw new NotImplementedException();
        }

        public override IList<IBaseTree<T>> GetDirectChildren()
        {
            Tree<T> current = next;
            IList<IBaseTree<T>> list = new List<IBaseTree<T>>();
            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }
            return list;
        }

        public ITree<T> AddChild(T data)
        {
            var child = new Tree<T>();
            child.head = this;
            child.data = data;
            next = child;
            return child;
        }

        public bool RemoveChild(ITree<T> t)
        {
            Tree<T> current = next;
            while (current != null)
            {
                if (current.Equals(t))
                {
                    current.head.next = current.next;
                    return true;
                }
                current = current.next;
            }
            return false;
        }
    }
}