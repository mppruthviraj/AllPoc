// A C / C++ program for Dijkstra's single source shortest path algorithm.
// The program is for adjacency matrix representation of the graph

#include <stdio.h>
#include <limits.h>

// Number of vertices in the graph
#define V 5

// A utility function to find the vertex with minimum distance value, from
// the set of vertices not yet included in shortest path tree
int minDistance(int dist[], bool sptSet[])
{
	// Initialize min value
	int min = INT_MAX, min_index;

	for (int v = 0; v < V; v++)
	{
		if (sptSet[v] == false && dist[v] <= min)
			min = dist[v], min_index = v;
	}
	return min_index;
}

// A utility function to print the constructed distance array
void printSolution(int dist[], int n)
{
	printf("Vertex   Distance from Source\n");
	for (int i = 0; i < V; i++)
		printf("%d \t\t %d\n", i, dist[i]);
}

// Funtion that implements Dijkstra's single source shortest path algorithm
// for a graph represented using adjacency matrix representation
void dijkstra(int graph[V][V], int src)
{
	int dist[V];     // The output array.  dist[i] will hold the shortest
	// distance from src to i

	bool sptSet[V]; // sptSet[i] will true if vertex i is included in shortest
	// path tree or shortest distance from src to i is finalized

	// Initialize all distances as INFINITE and stpSet[] as false
	for (int i = 0; i < V; i++)
		dist[i] = INT_MAX, sptSet[i] = false;

	// Distance of source vertex from itself is always 0
	dist[src] = 0;

	// Find shortest path for all vertices
	for (int count = 0; count < V - 1; count++)
	{
		// Pick the minimum distance vertex from the set of vertices not
		// yet processed. u is always equal to src in first iteration.
		int u = minDistance(dist, sptSet);

		// Mark the picked vertex as processed
		sptSet[u] = true;

		// Update dist value of the adjacent vertices of the picked vertex.
		for (int v = 0; v < V; v++)

			// Update dist[v] only if is not in sptSet, there is an edge from 
			// u to v, and total weight of path from src to  v through u is 
			// smaller than current value of dist[v]
			if (!sptSet[v] && graph[u][v] && dist[u] != INT_MAX
				&& dist[u] + graph[u][v] < dist[v])
				dist[v] = dist[u] + graph[u][v];
	}

	// print the constructed distance array
	printSolution(dist, V);
}



/* Function to sort an array using insertion sort*/
void insertionSort(int arr[], int n)
{
	int i, key, j;
	for (i = 1; i < n; i++)
	{
		key = arr[i];
		j = i - 1;

		/* Move elements of arr[0..i-1], that are
		greater than key, to one position ahead
		of their current position */
		while (j >= 0 && arr[j] > key)
		{
			arr[j + 1] = arr[j];
			j = j - 1;
		}
		arr[j + 1] = key;
	}
}

// A utility function ot print an array of size n
void printArray(int arr[], int n)
{
	int i;
	for (i = 0; i < n; i++)
		printf("%d ", arr[i]);
	printf("\n");
}

 //driver program to test above function
int main()
{
	//Let us create the example graph discussed above 
	int graph[V][V] = { {0,4,0,8,0},
	{ 4,0,3,0,0},
	{0,3,0,4,0},
	{8,0,4,0,7},
	{0,0,0,7,0}
	};

	dijkstra(graph, 0);

	int arr[] = { 12, 11, 13, 5, 6 };
	int n = sizeof(arr) / sizeof(arr[0]);

	
	insertionSort(arr, n);
	printArray(arr, n);

	return 0;
	getchar();
	return 0;
}

/*int decimal_binary(int n)  /* Function to convert decimal to binary.
{
	int rem, i = 1, binary = 0;
	while (n != 0)
	{
		rem = n % 2;
		n /= 2;
		binary += rem*i;
		i *= 10;
	}
	return binary;
}

int main()
{
	int n = 110111;
	/*char c='110111';
	printf("Instructions:\n");
	printf("1. Enter alphabet 'd' to convert binary to decimal.\n");
	printf("2. Enter alphabet 'b' to convert decimal to binary.\n");
	scanf("%c", &c);*/
	/*if (c == 'd' || c == 'D')
	{
		printf("Enter a binary number: ");
		scanf("%d", &n);
		printf("%d in binary = %d in decimal", n, binary_decimal(n));
	}
	//if (c == 'b' || c == 'B')
	//{
		//printf("Enter a decimal number: ");
		//scanf("%d", &n);
		printf("%d in decimal = %d in binary", n, decimal_binary(n));
	//}
	getchar();
	return 0;
}*/
