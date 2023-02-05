using System.Text;

namespace bl.Structures;
public class BinarySearchTree
{
    private Node _root { get; set; }

    public BinarySearchTree()
    {
        _root = null;
    }

    public void Add(int value)
    {
        var temp = new Node()
        {
            Value = value,
        };

        if (_root == null)
        {
            _root = temp;
        }
        else
        {
            InsertNode(_root, value);
        }
    }

    public string ShowPreOrder()
    {
        return $"Pre-orden: {PreOrder(_root, new StringBuilder())}";
    }

    public string ShowInOrder()
    {
        return $"In-orden: {InOrder(_root, new StringBuilder())}";
    }

    public string ShowPostOrder()
    {
        return $"Post-orden: {PostOrder(_root, new StringBuilder())}";
    }

    private void InsertNode(Node aux, int value)
    {
        if (aux.Value > value)
        {
            if (aux.Left == null)
            {
                aux.Left = new Node()
                {
                    Value = value,
                };
            }
            else
            {
                InsertNode(aux.Left, value);
            }
        }
        else
        {
            if (aux.Rigth == null)
            {
                aux.Rigth = new Node()
                {
                    Value = value,
                };
            }
            else
            {
                InsertNode(aux.Rigth, value);
            }
        }
    }

    private StringBuilder PreOrder(Node aux, StringBuilder stringBuilder)
    {
        if (aux == null)
        {
            return stringBuilder;
        }

        stringBuilder.Append($"{aux.Value}, ");
        PreOrder(aux.Left, stringBuilder);
        PreOrder(aux.Rigth, stringBuilder);

        return stringBuilder;
    }

    private StringBuilder InOrder(Node aux, StringBuilder stringBuilder)
    {
        if (aux == null)
        {
            return stringBuilder;
        }

        InOrder(aux.Left, stringBuilder);
        stringBuilder.Append($"{aux.Value}, ");
        InOrder(aux.Rigth, stringBuilder);

        return stringBuilder;
    }

    private StringBuilder PostOrder(Node aux, StringBuilder stringBuilder)
    {
        if (aux == null)
        {
            return stringBuilder;
        }

        PostOrder(aux.Left, stringBuilder);
        PostOrder(aux.Rigth, stringBuilder);
        stringBuilder.Append($"{aux.Value}, ");

        return stringBuilder;
    }
}