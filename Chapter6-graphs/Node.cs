namespace Chapter6_graphs
{
    public class Node<T>
    {
        public int Index { get; set; }
        public T Data { get; set; }
        public List<Node<T>> Neighbors { get; set; } = new List<Node<T>>();

        public override string ToString()
        {
            return $"Node with index {Index}: {Data}," + $"neighbours: {Neighbors.Count}";
        }
    }
}