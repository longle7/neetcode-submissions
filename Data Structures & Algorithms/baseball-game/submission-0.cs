public class Solution
{
    public int CalPoints(string[] operations)
    {
        var myStack = new Stack<int>();
        var sum = 0;
        foreach (var o in operations)
        {
            if (int.TryParse(o, out int val))
            {
                myStack.Push(val);
            }
            else if (o.Equals("+"))
            {
                int top = myStack.Pop();
                int second = myStack.Peek();
                myStack.Push(top);
                myStack.Push(top + second);
            }
            else if (o.Equals("C"))
            {
                myStack.Pop();
            }
            else if (o.Equals("D"))
            {
                myStack.Push(myStack.Peek() * 2);
            }
        }
        return myStack.Sum();
    }
}