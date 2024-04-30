namespace WellKnownProblems;

// BFS

public class BfsExample
{
    // Adjacent List
    private readonly Dictionary<Node, IEnumerable<Node>> _adj;

    private readonly Dictionary<Node, int> _level;

    // Parent Pointer
    private readonly Dictionary<Node, Node?> _parent;

    public BfsExample(
        Dictionary<Node, IEnumerable<Node>> adj,
        Dictionary<Node, int> level,
        Dictionary<Node, Node?> parent)
    {
        _adj = adj;
        _level = level;
        _parent = parent;
    }

    public void Bfs(Node s)
    {
        _level[s] = 0;
        _parent[s] = null;

        int i = 1;
        List<Node> frontier = [s];

        while (frontier.Count != 0)
        {
            List<Node> bag = [];

            foreach (var u in frontier)
            {
                foreach (var v in _adj[u])
                {
                    if (!_level.ContainsKey(v))
                    {
                        _level[v] = i;
                        _parent[v] = u;
                        bag.Add(v);
                    }
                }
            }

            frontier = bag;
            i++;
        }
    }
}
