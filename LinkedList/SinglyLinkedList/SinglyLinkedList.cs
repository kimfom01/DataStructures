namespace SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }

        public void AddFirst(SinglyLinkedListNode<T> node)
        {
            node.Next = Head;
            Head = node;
        }

        public void AddLast(SinglyLinkedListNode<T> node)
        {
            SinglyLinkedListNode<T> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
            node.Next = null;
        }

        public void AddAfter(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode)
        {
            if (node == null)
            {
                return;
            }

            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public void AddBefore(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode)
        {
            if (node == null)
            {
                return;
            }

            SinglyLinkedListNode<T> current = Head;

            while (current.Next != node)
            {
                current = current.Next;
            }

            newNode.Next = node;
            current.Next = newNode;
        }

        public void DisplayListData()
        {
            SinglyLinkedListNode<T> current = Head;

            while (current.Next != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }

            Console.WriteLine(current.Data);
        }

        public void DeleteFirst()
        {
            Head = Head.Next;
        }

        public void DeleteLast()
        {
            if (Head == null)
            {
                return;
            }

            SinglyLinkedListNode<T> current = Head;

            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }

        public void DeleteAfter(T data)
        {
            SinglyLinkedListNode<T> current = Head;
            SinglyLinkedListNode<T> node = new SinglyLinkedListNode<T>(data);

            while (!current.Data.Equals(node.Data))
            {
                current = current.Next;
            }

            node.Next = current.Next.Next;
            current.Next = node.Next;
        }

        public void DeleteBefore(T data)
        {
            SinglyLinkedListNode<T> current = Head;
            SinglyLinkedListNode<T> node = new SinglyLinkedListNode<T>(data);

            while (current.Next != null)
            {
                if (!current.Next.Next.Data.Equals(node.Data))
                {
                    current = current.Next;
                    continue;
                }

                current.Next = current.Next.Next;
                return;
            }
        }
    }
}