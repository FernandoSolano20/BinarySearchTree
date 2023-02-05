using bl.Structures;

namespace bl;
public class Business
{
    private readonly BinarySearchTree _tree;
    public Business()
    {
        _tree = new BinarySearchTree();
    }

    public void Add(int value)
    {
        _tree.Add(value);
    }

    public string ShowPreOrder()
    {
        return _tree.ShowPreOrder();
    }

    public string ShowInOrder()
    {
        return _tree.ShowInOrder();
    }

    public string ShowPostOrder()
    {
        return _tree.ShowPostOrder();
    }

    public string ShowTree()
    {
        return $"{ShowPreOrder()} \n{ShowInOrder()} \n{ShowPostOrder()}";
    }
}