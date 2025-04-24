namespace Intermediate_Excercises.Models
{
    //Section 4 Excercises 
    //Q#1 
    public class Stack
    {
        private readonly List<object> _elements = new List<object>();

        //push method 
        public void Push(object obj)
        {
            if (obj == null)
                Console.WriteLine("Cannot push null in the stack");

            _elements.Add(obj);
        }

        //pop method
        public Object Pop()
        {
            if (_elements.Count == 0)
                Console.WriteLine("Stack is Empty");

            int lastindex = _elements.Count - 1;
            object top = _elements[lastindex];
            _elements.RemoveAt(lastindex);
            return top;
        }

        //clear method
        public void Clear()
        {
            _elements.Clear();
        }

    }
}
