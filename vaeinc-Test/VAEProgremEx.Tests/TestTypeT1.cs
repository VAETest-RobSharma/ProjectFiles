namespace Test
{
    class T1
    {
        public T1()
        {
            
        }

        public static implicit operator string(T1 v)
        {
            return v.ToString();
        }
    }
}