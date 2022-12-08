using System.Collections;

namespace module_3;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }
        public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

        public bool Contains(int value) {
        // TODO Start Problem 2

        if (Data == value)
        {
            return true;
        }
        else if (Right is not null && Left is not null)
        {
            if (Right.Contains(value) || Left.Contains(value))
            {
                return true;
            }
        
        }
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4

        int rHeight = 0;
        int lHeight = 0;
        
        if (Left is not null)
        {
            lHeight = Left.GetHeight();
        }

        if (Right is not null)
        {
            rHeight = Right.GetHeight();
        }
        return 1+ Math.Max(rHeight, lHeight);
    }
}

public class BinarySearchTree : IEnumerable<int>{
    private Node? _root;

        public void Insert(int value) {

        Node newNode = new Node(value);

        if (_root is null)
            _root = newNode;
        else if (!_root.Contains(value))
        {
            _root.Insert(value);
        }
    }

        IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    public IEnumerator<int> GetEnumerator() {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    private void TraverseForward(Node? node, List<int> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    public int GetHeight() {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

}
 