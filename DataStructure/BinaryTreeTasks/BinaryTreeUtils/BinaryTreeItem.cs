using System;

namespace DataStructure.BinaryTreeTasks.BinaryTreeUtils
{
    public class BinaryTreeItem<T> where T : IComparable
    {
        public T Value;
        public BinaryTreeItem<T> LeftChild, RightChild;
    }
}
