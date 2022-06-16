namespace ADT_ASM_2
{
    public class Queue<T> 
    {
        private class Node              // Create a node
        {
            public T data;              //  T present for data that we want to use

            public Node(T data)
            {
                this.data = data;
            }

            public Node()
            {
                
            }
        }
        
        Node[] nodes;                 //  Create array of Node
        int current;
        int emptySpot;
        
        public int Size;
        
        public Queue(int size)        //Create a queue constructor can input size
        {
            nodes = new Node[size];
            for (int i = 0; i < size; i++)
            {
                nodes[i] = new Node();
            }
            this.current = 0;
            this.emptySpot = 0;
            Size = size;
        }

        public void Enqueue(T value)   // Enqueue function 
        {
            nodes[emptySpot].data = value;
            emptySpot++;
            if (emptySpot >= nodes.Length)
            {
                emptySpot = 0;
            }
        }

        public T Dequeue()            //   Dequeue function
        {
            int ret = current;
            current++;
            if (current >= nodes.Length)
            {
                current = 0;
            }
            return nodes[ret].data;
        }
    }
}