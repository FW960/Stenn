namespace Stenn.Task;

public class Tree
{
    public string Name { get; set; }
    public List<Tree> Childrens = new List<Tree>();

    /// <summary>
    /// Depth First Search Method that returns all values of tree
    /// </summary>
    /// <returns></returns>
    public List<Tree> DFS()
    {
        List<Tree> nodes = new List<Tree>();

        Stack<Tree> stack = new Stack<Tree>();
        stack.Push(this);

        return DFS(nodes, stack);
    }

    private List<Tree> DFS(List<Tree> nodes, Stack<Tree> stack)
    {
        if (Childrens.Count() == 0)
        {
            nodes.Add(stack.Pop());
            return nodes;
        }

        foreach (var child in Childrens)
        {
            stack.Push(child);
            child.DFS(nodes, stack);
        }

        nodes.Add(stack.Pop());

        return nodes;
    }

    /// <summary>
    /// Breadth First Search Method that returns all values of tree
    /// </summary>
    /// <returns></returns>
    public List<Tree> BFS()
    {
        List<Tree> nodes = new List<Tree>();

        nodes.Add((this));

        Queue<Tree> queue = new Queue<Tree>();

        return BFS(nodes, queue);
    }

    private List<Tree> BFS(List<Tree> nodes, Queue<Tree> queue)
    {
        if (Childrens.Count == 0)
        {
            if (queue.Count != 0)
            {
                nodes.Add(queue.Dequeue());
                nodes.Last().BFS(nodes, queue);
            }

            return nodes;
        }

        foreach (var node in Childrens)
        {
            queue.Enqueue(node);
        }

        nodes.Add(queue.Dequeue());

        return nodes.Last().BFS(nodes, queue);
    }
}