namespace WellKnownProblems;

public class UnionFind
{
    private readonly int[] _parent;

    private readonly int[] _size;

    public UnionFind(int size)
    {
        _parent = Enumerable.Range(0, size).ToArray();
        _size = Enumerable.Repeat(1, size).ToArray();
    }

    public int Find(int x)
    {
        if (x != _parent[x])
            _parent[x] = Find(_parent[x]);

        return _parent[x];
    }

    public int Find2(int x)
    {
        while (x != _parent[x])
        {
            _parent[x] = _parent[_parent[x]];
            x = _parent[x];
        }

        return x;
    }

    public int Find3(int x)
    {
        int root = x;
        while (root != _parent[root])
        {
            root = _parent[root];
        }

        while (x != _parent[x])
        {
            var t = _parent[x];
            _parent[x] = root;
            x = t;
        }

        return x;
    }

    public void Union(int x, int y)
    {
        int u = Find(x);
        int v = Find(y);

        if (u == v)
            return;

        if (_size[u] < _size[v])
        {
            _parent[u] = v;
            _size[v] += _size[u];
        }
        else
        {
            _parent[v] = u;
            _size[u] += _size[v];
        }
    }
}
