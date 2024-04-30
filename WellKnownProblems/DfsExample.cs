namespace WellKnownProblems;

// DFS

public class DfsExample
{
    // Adjacent List
    private readonly Dictionary<Node, IEnumerable<Node>> _adj;

    // Parent Pointer
    private readonly Dictionary<Node, Node?> _parent;

    public DfsExample(
        Dictionary<Node, IEnumerable<Node>> adj,
        Dictionary<Node, Node?> parent)
    {
        _adj = adj;
        _parent = parent;
    }

    // iterating over the outgoing edges from s
    public void DfsVisit(Node s)
    {
        foreach (var v in _adj[s])
        {
            if (!_parent.ContainsKey(v))
            {
                _parent[v] = s;
                DfsVisit(v);
            }
        }
    }

    // iterating over the choices of s
    public void Dfs(IEnumerable<Node> vertices)
    {
        foreach (var s in vertices)
        {
            if (!_parent.ContainsKey(s))
            {
                _parent[s] = null;
                DfsVisit(s);
            }
        }
    }
}
