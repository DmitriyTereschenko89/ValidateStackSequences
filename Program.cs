namespace ValidateStackSequences
{
    internal class Program
    {
        public class StackSequencesValidate
        {
            public bool ValidateStackSequences(int[] pushed, int[] popped)
            {
                int n = popped.Length;
                Stack<int> st = new();
                int poppedIdx = 0;
                foreach(int push in pushed)
                {
                    st.Push(push);
                    while(st.Count > 0 && poppedIdx < n && st.Peek() == popped[poppedIdx])
                    {
                        st.Pop();
                        ++poppedIdx;
                    }
                }
                return poppedIdx == n;
            }
        }
        static void Main(string[] args)
        {
            StackSequencesValidate stackSequencesValidate = new();
            Console.WriteLine(stackSequencesValidate.ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 }));
            Console.WriteLine(stackSequencesValidate.ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2 }));
        }
    }
}