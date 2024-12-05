//Dijkstra’s Algorithm
// Finds the shortest path from a source node to all other nodes in a graph.

void Dijkstra(int source, int[,] graph)
{
    int n = graph.GetLength(0);
    int[] distances = Enumerable.Repeat(int.MaxValue, n).ToArray();
    distances[source] = 0;
    bool[] visited = new bool[n];

    for (int i = 0; i < n; i++)
    {
        int u = -1;
        for (int j = 0; j < n; j++)
        {
            if (!visited[j] && (u == -1 || distances[j] < distances[u]))
                u = j;
        }
        visited[u] = true;

        for (int v = 0; v < n; v++)
        {
            if (graph[u, v] > 0 && !visited[v])
                distances[v] = Math.Min(distances[v], distances[u] + graph[u, v]);
        }
    }

    Console.WriteLine(string.Join(", ", distances));
}
