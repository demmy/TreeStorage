namespace Abstract
{
    public interface IBinaryTree<T> : IBaseTree<T>
    {
        T LeftData { set; }
        T RightData { set; }
        IBinaryTree<T> Left { get; }
        IBinaryTree<T> Right { get; }
    }
}