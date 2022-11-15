namespace Stack_Array;
public class Stack_Array<T>
{
    private int _maxSize;

    private T[] _stack;

    private int _top;

    public Stack_Array(int maxSize)
    {
        _maxSize = maxSize;

        _stack = new T[_maxSize];

        _top = -1;
    }

    public void Push(T item)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("You cannot add items to a stack that is full");
        }
        
        _stack[++_top] = item;
    }

    public T Pop()
    {
        if (!IsEmpty())
        {
            throw new InvalidOperationException("You cannot remove items from an empty stack");
        }

        _stack[_top] = default;

        return _stack[_top--];
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("There is nothing in your stack");
        }

        return _stack[_top];
    }

    private bool IsEmpty()
    {
        return _top == -1;
    }

    private bool IsFull()
    {
        return _top == _maxSize - 1;
    }
}
